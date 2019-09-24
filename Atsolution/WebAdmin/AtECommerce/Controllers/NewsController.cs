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
    public class NewsController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;
        public NewsController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                //get  bai dang
                ViewData["ControllerNameForGrid"] = nameof(NewsController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request)
        {
            var query = _webcontext.News.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal)
                .Select(h => new NewsDetailsViewModel
                {


                    Id = h.Id,
                    Title = h.Title,
                    Slug_Title = h.SlugTitle,
                    AutoSlug = h.AutoSlug,
                    FkNewsTypeId = h.FkNewsTypeId,
                    // Ford
                    ShortDescription_Html = h.ShortDescriptionHtml,
                    LongDescription_Html = h.LongDescriptionHtml,
                    Tags = h.Tags,
                    ImageSlug = h.ImageSlug,
                    KeyWord = h.KeyWord,
                    MetaData = h.MetaData,
                    Note = h.Note,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    UpdatedBy = h.UpdatedBy,
                    UpdatedDate = h.UpdatedDate,
                    RowVersion = h.RowVersion,
                    RowStatus = (AtRowStatus)h.RowStatus

                });

            return Json(await query.ToDataSourceResultAsync(request));
        }
        // GET: chi tiết bài đăng
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var news = await _webcontext.News.AsNoTracking()

                    .Include(p => p.FkNewsType)
                        .Where(h => h.SlugTitle == id)
                    .FirstOrDefaultAsync();
                if (news == null)
                {
                    return NotFound();
                }

                return View(news);
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        // GET: tạo mới bài đăng
        public async Task<IActionResult> Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserNewController).Replace("Controller", "");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey();

                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        // create bài đăng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] NewsCreateViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserNewController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(News);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            // Trim white space
            //vmItem.Id = $"{vmItem.Id}".Trim();
            vmItem.Title = $"{vmItem.Title}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.Slug_Title = NormalizeSlug($"{vmItem.Title}");
            }
            else
            {
                vmItem.Slug_Title = NormalizeSlug($"{vmItem.Slug_Title}");
            }

            // Check code is existed
            if (await _webcontext.News.AnyAsync(h => h.SlugTitle == vmItem.Slug_Title))
            {
                ModelState.AddModelError(nameof(News.SlugTitle), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.News.AsNoTracking()
                    .Where(h => h.SlugTitle.StartsWith(vmItem.Slug_Title))
                    .Select(h => h.SlugTitle).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Slug_Title, listExistedSlug);

            // Create save db item
            var dbItem = new News
            {
                Id = Guid.NewGuid().ToString(),

                CreatedBy = _loginUserId,
                CreatedDate = DateTime.Now,
                UpdatedBy = null,
                UpdatedDate = null,
                RowStatus = (int)AtRowStatus.Normal,
                RowVersion = null,
                Title = vmItem.Title,
                SlugTitle = vmItem.Slug_Title,
                AutoSlug = vmItem.AutoSlug,
                FkNewsTypeId = vmItem.FkNewsTypeId,
                ImageSlug = vmItem.ImageSlug,
                ShortDescriptionHtml = vmItem.ShortDescription_Html,
                LongDescriptionHtml = vmItem.LongDescription_Html,
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

        private async Task PrepareListMasterForeignKey(NewsBaseViewModel vm = null)
        {
            ViewData["FkNewsTypeId"] = new SelectList(
                await _webcontext.NewsType.AsNoTracking()
                    .Select(h => new { h.Id, h.Name })
                    .OrderByDescending(h => h.Name)
                    .ToListAsync(),
                "Id", "Name", vm?.FkNewsTypeId);
        }

        // EDIT NEWS
        public async Task<IActionResult> Edit([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserNewController).Replace("Controller", "");

                var dbItem = await _webcontext.News.AsNoTracking()
                .Where(h => h.SlugTitle == id)

                    .Select(h => new NewsEditViewModel
                    {
                        Id = h.Id,
                        Title = h.Title,
                        Slug_Title = h.SlugTitle,
                        AutoSlug = h.AutoSlug,
                        FkNewsTypeId = h.FkNewsTypeId,
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

                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(dbItem);

                return View(dbItem);
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] NewsEditViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserNewController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(News);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.News
                .Where(h => h.Id == vmItem.Id)

                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            // Trim white space
            //vmItem.Id = $"{vmItem.Id}".Trim();
            vmItem.Title = $"{vmItem.Title}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.Slug_Title = NormalizeSlug($"{vmItem.Title}");
            }
            else
            {
                vmItem.Slug_Title = NormalizeSlug($"{vmItem.Slug_Title}");
            }

            // Check code is existed
            if (await _webcontext.News.AnyAsync(h => h.Id != vmItem.Id && h.SlugTitle == vmItem.Slug_Title))
            {
                ModelState.AddModelError(nameof(News.SlugTitle), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.News.AsNoTracking()
                    .Where(h => h.Id != vmItem.Id && h.SlugTitle.StartsWith(vmItem.Slug_Title))
                    .Select(h => h.SlugTitle).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Slug_Title, listExistedSlug);

            // Update db item               
            dbItem.UpdatedBy = _loginUserId;
            dbItem.UpdatedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.Title = vmItem.Title;
            dbItem.SlugTitle = vmItem.Slug_Title;
            dbItem.AutoSlug = vmItem.AutoSlug;
            dbItem.FkNewsTypeId = vmItem.FkNewsTypeId;
            dbItem.ImageSlug = vmItem.ImageSlug;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord = vmItem.KeyWord;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note = vmItem.Note;

            _webcontext.Entry(dbItem).Property(nameof(News.RowVersion)).OriginalValue = vmItem.RowVersion;
            // Set time stamp for table to handle concurrency conflict
            tableVersion.LastModify = DateTime.Now;
            await _webcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.SlugTitle });
        }

        // delete bài đăng
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var dbItem = await _webcontext.News.AsNoTracking()

                    .Include(p => p.FkNewsType)
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

        // POST: News /Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromForm] string id, [FromForm] byte[] rowVersion)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbItem = await _webcontext.News

                .Include(p => p.FkNewsType)
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

                _webcontext.Entry(dbItem).Property(nameof(News.RowVersion)).OriginalValue = rowVersion;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }
    }
    public class ImageBrowserNewController : EditorImageBrowserController
    {
        public const string FOLDER_NAME = "ImagesNews";
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

        public ImageBrowserNewController(IHostingEnvironment hostingEnvironment, IConfiguration staticFileSetting)
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

    public class NewsBaseViewModel
    {
        public String Title { get; set; }
        public String Slug_Title { get; set; }
        public Boolean AutoSlug { get; set; }
        public String FkNewsTypeId { get; set; }
        public String ShortDescription_Html { get; set; }
        public String LongDescription_Html { get; set; }
        public String Tags { get; set; }
        public String KeyWord { get; set; }
        public String MetaData { get; set; }
        public String Note { get; set; }
        public String ImageSlug { get; set; }
    }

    public class NewsDetailsViewModel : NewsBaseViewModel
    {

        public String Id { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }
        public int SortIndex { get; set; }

        public virtual NewsType FkNewsType { get; set; }
    }

    public class NewsCreateViewModel : NewsBaseViewModel
    {

    }

    public class NewsEditViewModel : NewsBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class NewsBaseValidator<T> : AtBaseValidator<T> where T : NewsBaseViewModel
    {
        public NewsBaseValidator()
        {

            RuleFor(h => h.Title)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Slug_Title)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.AutoSlug)
                ;

            RuleFor(h => h.FkNewsTypeId)
                        .NotEmpty()
                        .MaximumLength(50)
                ;


            RuleFor(h => h.ShortDescription_Html)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.LongDescription_Html)
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
    public class NewsCreateValidator : NewsBaseValidator<NewsCreateViewModel>
    {
        public NewsCreateValidator()
        {
        }
    }

    public class NewsEditValidator : NewsBaseValidator<NewsEditViewModel>
    {
        public NewsEditValidator()
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