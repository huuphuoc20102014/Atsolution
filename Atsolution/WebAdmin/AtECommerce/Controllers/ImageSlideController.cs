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
using AtECommerce.Efs.Entities;
using GenEf.Efs.Entities;
using Microsoft.Extensions.Configuration;

namespace AtECommerce.Controllers
{
    public class ImageSlideController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;
        public ImageSlideController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }

        //display data
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                ImageSlide dbItem = null;
                if (!string.IsNullOrWhiteSpace(id))
                {
                    dbItem = await _webcontext.ImageSlide.AsNoTracking().FirstOrDefaultAsync(h => h.SlugName == id);
                    if (dbItem == null)
                    {
                        return NotFound();
                    }
                }
                ViewData["ParentItem"] = dbItem;

                ViewData["ControllerNameForGrid"] = nameof(ImageSlideController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request, string parentId)
        {
            var baseQuery = _webcontext.ImageSlide.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal);
            if (!string.IsNullOrWhiteSpace(parentId))
            {
                baseQuery = baseQuery.Where(h => h.Id == parentId);
            }
            var query = baseQuery
                .Select(h => new ImageSlideDetailsViewModel
                {
                    Id = h.Id,
                    Thumbnail = h.Thumbnail,
                    Name = h.Name,
                    SlugName = h.SlugName,
                    SortIndex = h.SortIndex,
                    Tags = h.Tags,
                    KeyWord = h.KeyWord,
                    MetaData = h.MetaData,
                    Note = h.Note,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    UpdatedBy = h.UpdatedBy,
                    UpdatedDate = h.UpdatedDate,
                    RowVersion = h.RowVersion,
                    Type = h.Type,
                });

            return Json(await query.ToDataSourceResultAsync(request));
        }

        //display details of image
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var imageslide = await _webcontext.ImageSlide.AsNoTracking()
                        .Where(h => h.SlugName == id)
                    .FirstOrDefaultAsync();
                if (imageslide == null)
                {
                    return NotFound();
                }

                return View(imageslide);
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
                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserImageSlideController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] ImageSlideCreateViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserImageSlideController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(ImageSlide);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(p => p.Id == tableName);
            // Trim white space
            vmItem.Name = $"{vmItem.Name}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.SlugName = NormalizeSlug($"{vmItem.Name}");
            }
            else
            {
                vmItem.SlugName = NormalizeSlug($"{vmItem.SlugName}");
            }

            // Check code is existed
            if (await _webcontext.ImageSlide.AnyAsync(h => h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(ImageSlide.Name), "The Name has been existed.");
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.ImageSlide.AsNoTracking()
                    .Where(h => h.SlugName.StartsWith(vmItem.SlugName))
                    .Select(h => h.SlugName).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.SlugName, listExistedSlug);

            // Create save db item
            var dbItem = new ImageSlide
            {
                Id = Guid.NewGuid().ToString(),

                CreatedBy = _loginUserId,
                CreatedDate = DateTime.Now,
                UpdatedBy = null,
                UpdatedDate = null,
                RowStatus = (int)AtRowStatus.Normal,
                RowVersion = null,

                Name = vmItem.Name,
                SlugName = vmItem.SlugName,
                AutoSlug = vmItem.AutoSlug,
                IsYoutube = vmItem.IsYoutube,
                YoutubeLink = vmItem.YoutubeLink,
                Thumbnail = vmItem.Thumbnail,
                SortIndex = vmItem.SortIndex,
                Note = vmItem.Note,
                Tags = vmItem.Tags,
                KeyWord = vmItem.KeyWord,
                MetaData = vmItem.MetaData,
                Extension = "Exte",
                Type = vmItem.Type
            };
            _webcontext.Add(dbItem);
            // Set time stamp for table to handle concurrency conflict     

            tableVersion.LastModify = DateTime.Now;

            await _webcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = dbItem.SlugName });
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

                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserImageSlideController).Replace("Controller", "");

                var dbItem = await _webcontext.ImageSlide.AsNoTracking()
                    .Where(h => h.SlugName == id)
                    .Select(h => new ImageSlideEditViewModel
                    {
                        Id = h.Id,
                        Name = h.Name,
                        SlugName = h.SlugName,
                        AutoSlug = h.AutoSlug,
                        YoutubeLink = h.YoutubeLink,
                        Thumbnail = h.Thumbnail,
                        SortIndex = h.SortIndex,
                        Note = h.Note,
                        Tags = h.Tags,
                        KeyWord = h.KeyWord,
                        MetaData = h.MetaData,
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
        public async Task<IActionResult> Edit([FromForm] ImageSlideEditViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserImageSlideController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(ImageSlide);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.ImageSlide
                .Where(h => h.Id == vmItem.Id)

                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            // Trim white space
            vmItem.Name = $"{vmItem.Name}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.SlugName = NormalizeSlug($"{vmItem.Name}");
            }
            else
            {
                vmItem.SlugName = NormalizeSlug($"{vmItem.SlugName}");
            }

            // Check code is existed
            if (await _webcontext.ImageSlide.AnyAsync(h => h.Id != vmItem.Id && h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(ImageSlide.Name), "The Name has been existed.");
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.ImageSlide.AsNoTracking()
                    .Where(h => h.Id != vmItem.Id && h.SlugName.StartsWith(vmItem.SlugName))
                    .Select(h => h.SlugName).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.SlugName, listExistedSlug);

            // Update db item               
            dbItem.UpdatedBy = _loginUserId;
            dbItem.UpdatedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.Name = vmItem.Name;
            dbItem.SlugName = vmItem.SlugName;
            dbItem.AutoSlug = vmItem.AutoSlug;
            dbItem.Thumbnail = vmItem.Thumbnail;
            dbItem.SortIndex = vmItem.SortIndex;
            dbItem.IsYoutube = vmItem.IsYoutube;
            dbItem.YoutubeLink = vmItem.YoutubeLink;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord = vmItem.KeyWord;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note = vmItem.Note;
            dbItem.Type = vmItem.Type;

            _webcontext.Entry(dbItem).Property(nameof(ImageSlide.RowVersion)).OriginalValue = vmItem.RowVersion;
            // Set time stamp for table to handle concurrency conflict
            tableVersion.LastModify = DateTime.Now;
            await _webcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.SlugName });
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

                var dbItem = await _webcontext.ImageSlide.AsNoTracking()
                        .Where(h => h.SlugName == id)
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
            var tableName = nameof(ImageSlide);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.ImageSlide
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
            if (dbItem.RowStatus != (Int32)AtRowStatus.Deleted)
            {
                dbItem.RowStatus = (Int32)AtRowStatus.Deleted;
                dbItem.UpdatedBy = _loginUserId;
                dbItem.UpdatedDate = DateTime.Now;
                dbItem.RowVersion = rowVersion;

                _webcontext.Entry(dbItem).Property(nameof(ImageSlide.RowVersion)).OriginalValue = rowVersion;
                // Set time stamp for table to handle concurrency conflict
                tableVersion.LastModify = DateTime.Now;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }
    }

    public class ImageBrowserImageSlideController : EditorImageBrowserController
    {
        public const string FOLDER_NAME = "ImagesSlider";
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

        public ImageBrowserImageSlideController(IHostingEnvironment hostingEnvironment, IConfiguration staticFileSetting)
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

    public class ImageSlideBaseViewModel
    {
        public string Name { get; set; }
        public string SlugName { get; set; }
        public bool AutoSlug { get; set; }
        public string Description { get; set; }
        public int SortIndex { get; set; }
        public bool IsYoutube { get; set; }
        public string YoutubeLink { get; set; }
        public string Thumbnail { get; set; }
        public string Note { get; set; }
        public string Tags { get; set; }
        public string KeyWord { get; set; }
        public string MetaData { get; set; }
        public int? Type { get; set; }
    }

    public class ImageSlideDetailsViewModel : ImageSlideBaseViewModel
    {
        public string Id { get; set; }
        public string Extension { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public int RowStatus { get; set; }
    }

    public class ImageSlideCreateViewModel : ImageSlideBaseViewModel
    {

    }

    public class ImageSlideEditViewModel : ImageSlideBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class ImageSlideBaseValidator<T> : AtBaseValidator<T> where T : ImageSlideBaseViewModel
    {
        public ImageSlideBaseValidator()
        {
            RuleFor(h => h.Name)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.SlugName)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.AutoSlug)
                ;

            RuleFor(h => h.YoutubeLink)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.Thumbnail)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.SortIndex)
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

    public class ImageSlideCreateValidator : ImageSlideBaseValidator<ImageSlideCreateViewModel>
    {
        public ImageSlideCreateValidator()
        {
        }
    }

    public class ImageSlideEditValidator : ImageSlideBaseValidator<ImageSlideEditViewModel>
    {
        public ImageSlideEditValidator()
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
