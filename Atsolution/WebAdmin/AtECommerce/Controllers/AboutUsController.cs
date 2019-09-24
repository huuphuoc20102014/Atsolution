using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Hosting;
using GenEf.Efs.Entities;
using Microsoft.Extensions.Configuration;

namespace AtECommerce.Controllers
{
    public class AboutUsController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;

        public AboutUsController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }

        //GET data from db
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AboutUs dbItem = null;
                if (!string.IsNullOrWhiteSpace(id))
                {
                    dbItem = await _webcontext.AboutUs.AsNoTracking().FirstOrDefaultAsync(h => h.SlugTitle == id);
                    if (dbItem == null)
                    {
                        return NotFound();
                    }
                }
                ViewData["ParentItem"] = dbItem;

                ViewData["ControllerNameForGrid"] = nameof(AboutUsController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        //Display data
        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request)
        {
            var query = _webcontext.AboutUs.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal) //rowstatus == 0
                .Select(h => new AboutUsDetailsViewModel
                {
                    Id = h.Id,
                    Title = h.Title,
                    SlugTitle = h.SlugTitle,
                    AutoSlug = h.AutoSlug,
                    ShortDescriptionHtml = h.ShortDescriptionHtml,
                    LongDescriptionHtml = h.LongDescriptionHtml,
                    ImageSlug = h.ImageSlug,
                    Tags = h.Tags,
                    KeyWord = h.KeyWord,
                    MetaData = h.MetaData,
                    Note = h.Note,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    UpdatedBy = h.UpdatedBy,
                    UpdatedDate = h.UpdatedDate,
                    RowVersion = h.RowVersion,
                    RowStatus = (AtRowStatus)h.RowStatus,
                });

            return Json(await query.ToDataSourceResultAsync(request));
        }

        //Detail About Us
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }
                var aboutus = await _webcontext.AboutUs.AsNoTracking()
                        .Where(h => h.SlugTitle == id)
                        .FirstOrDefaultAsync();
                if (aboutus == null)
                {
                    return NotFound();
                }

                return View(aboutus);
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        //CREATE
        public async Task<IActionResult> Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAboutUsController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] AboutUsCreateViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAboutUsController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(AboutUs);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            // Trim white space
            vmItem.Title = $"{vmItem.Title}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.SlugTitle = NormalizeSlug($"{vmItem.Title}");
            }
            else
            {
                vmItem.SlugTitle = NormalizeSlug($"{vmItem.SlugTitle}");
            }

            // Check Title is existed
            if (await _webcontext.AboutUs.AnyAsync(h => h.SlugTitle == vmItem.SlugTitle))
            {
                ModelState.AddModelError(nameof(AboutUs.SlugTitle), "The SlugTitle has been existed.");
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.AboutUs.AsNoTracking()
                    .Where(h => h.SlugTitle.StartsWith(vmItem.SlugTitle))
                    .Select(h => h.SlugTitle).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.SlugTitle, listExistedSlug);

            // Create save db item
            var dbItem = new AboutUs
            {
                Id = Guid.NewGuid().ToString(),

                CreatedBy = _loginUserId,
                CreatedDate = DateTime.Now,
                UpdatedBy = null,
                UpdatedDate = null,
                RowStatus = (int)AtRowStatus.Normal,
                RowVersion = null,

                Title = vmItem.Title,
                SlugTitle = vmItem.SlugTitle,
                AutoSlug = vmItem.AutoSlug,
                ShortDescriptionHtml = vmItem.ShortDescriptionHtml,
                LongDescriptionHtml = vmItem.LongDescriptionHtml,
                ImageSlug = vmItem.ImageSlug,
                Tags = vmItem.Tags,
                KeyWord = vmItem.KeyWord,
                MetaData = vmItem.MetaData,
                Note = vmItem.Note,
            };
            _webcontext.Add(dbItem);

            // Set time stamp for table to handle concurrency conflict
            if (tableVersion != null)
            {
                tableVersion.LastModify = DateTime.Now;
            }
            await _webcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.SlugTitle });
        }

        //EDIT
        public async Task<IActionResult> Edit([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAboutUsController).Replace("Controller", "");

                var dbItem = await _webcontext.AboutUs.AsNoTracking()

            .Where(h => h.SlugTitle == id)

                    .Select(h => new AboutUsEditViewModel
                    {
                        Id = h.Id,
                        Title = h.Title,
                        SlugTitle = h.SlugTitle,
                        AutoSlug = h.AutoSlug,
                        ShortDescriptionHtml = h.ShortDescriptionHtml,
                        LongDescriptionHtml = h.LongDescriptionHtml,
                        ImageSlug = h.ImageSlug,
                        Tags = h.Tags,
                        KeyWord = h.KeyWord,
                        MetaData = h.MetaData,
                        Note = h.Note,
                        RowVersion = h.RowVersion,
                    })
                    .FirstOrDefaultAsync();
                if (dbItem == null)
                {
                    return NotFound();
                }

                return View(dbItem);
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] AboutUsEditViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAboutUsController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(AboutUs);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.AboutUs
                .Where(h => h.Id == vmItem.Id)

                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            // Trim white space
            vmItem.Title = $"{vmItem.Title}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.SlugTitle = NormalizeSlug($"{vmItem.Title}");
            }
            else
            {
                vmItem.SlugTitle = NormalizeSlug($"{vmItem.SlugTitle}");
            }

            // Check code is existed
            if (await _webcontext.AboutUs.AnyAsync(h => h.Id != vmItem.Id && h.SlugTitle == vmItem.SlugTitle))
            {
                ModelState.AddModelError(nameof(AboutUs.SlugTitle), "The SlugTitle has been existed.");
                // Get list master of foreign property and set to view data
                //await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.AboutUs.AsNoTracking()
                    .Where(h => h.Id != vmItem.Id && h.SlugTitle.StartsWith(vmItem.SlugTitle))
                    .Select(h => h.SlugTitle).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.SlugTitle, listExistedSlug);

            // Update db item               
            dbItem.UpdatedBy = _loginUserId;
            dbItem.UpdatedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.Title = vmItem.Title;
            dbItem.SlugTitle = vmItem.SlugTitle;
            dbItem.AutoSlug = vmItem.AutoSlug;
            dbItem.ShortDescriptionHtml = vmItem.ShortDescriptionHtml;
            dbItem.LongDescriptionHtml = vmItem.LongDescriptionHtml;
            dbItem.ImageSlug = vmItem.ImageSlug;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord = vmItem.KeyWord;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note = vmItem.Note;

            _webcontext.Entry(dbItem).Property(nameof(AboutUs.RowVersion)).OriginalValue = vmItem.RowVersion;

            tableVersion.LastModify = DateTime.Now;
            await _webcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.SlugTitle });
        }

        //DELETE
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var dbItem = await _webcontext.AboutUs.AsNoTracking()
                        .Where(h => h.SlugTitle == id)
                    .FirstOrDefaultAsync();
                if (dbItem == null)
                {
                    return NotFound();
                }

                return View(dbItem);
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromForm] string id, [FromForm] byte[] rowVersion)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(AboutUs);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.AboutUs
                .Where(h => h.Id == id)
                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            if (rowVersion == null)
            {
                ModelState.AddModelError("RowVersion", "Invalid row version, please try again.");
                return View(dbItem);
            }

            // Update db item               
            if (dbItem.RowStatus != (int)AtRowStatus.Deleted)
            {
                dbItem.RowStatus = (int)AtRowStatus.Deleted;
                dbItem.UpdatedBy = _loginUserId;
                dbItem.UpdatedDate = DateTime.Now;
                dbItem.RowVersion = rowVersion;

                _webcontext.Entry(dbItem).Property(nameof(AboutUs.RowVersion)).OriginalValue = rowVersion;

                // Set time stamp for table to handle concurrency conflict
                tableVersion.LastModify = DateTime.Now;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }
    }

    public class ImageBrowserAboutUsController : EditorImageBrowserController
    {
        public const string FOLDER_NAME = "ImagesAboutUs";
        public string FOLDER_ROOTPATH;

        /// <summary>
        /// Gets the base paths from which content will be served.
        /// </summary>
        public override string ContentPath
        {
            get
            {
                return CreateUserFolder();
            }
        }

        public ImageBrowserAboutUsController(IHostingEnvironment hostingEnvironment, IConfiguration staticFileSetting)
            : base(hostingEnvironment)
        {
            FOLDER_ROOTPATH = staticFileSetting.GetValue<string>("StaticFileSetting");
        }
        private string CreateUserFolder()
        {
            var virtualPath = System.IO.Path.Combine(FOLDER_NAME);
            //var path = HostingEnvironment.WebRootFileProvider.GetFileInfo(virtualPath).PhysicalPath;
            var path = System.IO.Path.Combine(FOLDER_ROOTPATH, FOLDER_NAME);
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return path;
        }
    }

    public class AboutUsBaseViewModel
    {
        public string Title { get; set; }
        public string SlugTitle { get; set; }
        public bool AutoSlug { get; set; }
        public string ShortDescriptionHtml { get; set; }
        public string LongDescriptionHtml { get; set; }
        public string ImageSlug { get; set; }
        public string Tags { get; set; }
        public string KeyWord { get; set; }
        public string MetaData { get; set; }
        public string Note { get; set; }
    }

    public class AboutUsDetailsViewModel : AboutUsBaseViewModel
    {
        public String Id { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }
    }

    public class AboutUsCreateViewModel : AboutUsBaseViewModel
    {

    }

    public class AboutUsEditViewModel : AboutUsBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class AboutUsBaseValidator<T> : AtBaseValidator<T> where T : AboutUsBaseViewModel
    {
        public AboutUsBaseValidator()
        {

            RuleFor(h => h.Title)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.SlugTitle)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.AutoSlug)
                ;

            RuleFor(h => h.ShortDescriptionHtml)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.LongDescriptionHtml)
                ;

            RuleFor(h => h.ImageSlug)
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Tags)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.KeyWord)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.MetaData)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.Note)
                        .MaximumLength(1000)
                ;

        }
    }

    public class AboutUsCreateValidator : AboutUsBaseValidator<AboutUsCreateViewModel>
    {
        public AboutUsCreateValidator()
        {
        }
    }

    public class AboutUsEditValidator : AboutUsBaseValidator<AboutUsEditViewModel>
    {
        public AboutUsEditValidator()
        {
            RuleFor(h => h.Id)
                        .NotEmpty()
                        .MaximumLength(50)
                ;

            RuleFor(h => h.RowVersion)
                        .NotNull()
                ;

        }
    }
}