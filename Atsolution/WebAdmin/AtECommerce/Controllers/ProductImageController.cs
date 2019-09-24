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
    public class ProductImageController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;
        public ProductImageController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                ProductImage dbItem = null;
                if (!string.IsNullOrWhiteSpace(id))
                {
                    dbItem = await _webcontext.ProductImage.AsNoTracking().FirstOrDefaultAsync(h => h.SlugName == id);
                    if (dbItem == null)
                    {
                        return NotFound();
                    }
                }
                ViewData["ParentItem"] = dbItem;

                ViewData["ControllerNameForGrid"] = nameof(ProductImageController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request, string parentId)
        {
            var baseQuery = _webcontext.ProductImage.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal);
            if (!string.IsNullOrWhiteSpace(parentId))
            {
                baseQuery = baseQuery.Where(h => h.Id == parentId);
            }
            var query = baseQuery
                .Select(h => new ProductImageDetailsViewModel
                {
                    Id = h.Id,
                    Thumbnail = h.Thumbnail,
                    Name = h.Name,
                    SlugName = h.SlugName,
                    FkProductId = h.FkProductId,
                    SortIndex = h.SortIndex,
                    Tags = h.Tags,
                    KeyWord = h.KeyWord,
                    MetaData = h.MetaData,
                    Note = h.Note,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    UpdatedBy = h.UpdatedBy,
                    UpdatedDate = h.UpdatedDate,
                    RowVersion = h.RowVersion
                });

            return Json(await query.ToDataSourceResultAsync(request));
        }
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var ProductImage = await _webcontext.ProductImage.AsNoTracking()
                        .Where(h => h.SlugName == id)
                    .FirstOrDefaultAsync();
                if (ProductImage == null)
                {
                    return NotFound();
                }

                return View(ProductImage);
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
                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductImageController).Replace("Controller", "");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey();

                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] ProductImageCreateViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductImageController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(ProductImage);
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
            if (await _webcontext.ProductImage.AnyAsync(h => h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(ProductImage.Name), "The Name has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.ProductImage.AsNoTracking()
                    .Where(h => h.SlugName.StartsWith(vmItem.SlugName))
                    .Select(h => h.SlugName).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.SlugName, listExistedSlug);

            // Create save db item
            var dbItem = new ProductImage
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
                FkProductId = vmItem.FkProductId,
                Thumbnail = vmItem.Thumbnail,
                SortIndex = vmItem.SortIndex,
                Tags = vmItem.Tags,
                KeyWord = vmItem.KeyWord,
                MetaData = vmItem.MetaData,
                Note = vmItem.Note,
                Extension = "Exten"
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

                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductImageController).Replace("Controller", "");

                var dbItem = await _webcontext.ProductImage.AsNoTracking()

        .Where(h => h.SlugName == id)

                    .Select(h => new ProductImageEditViewModel
                    {
                        Id = h.Id,
                        Name = h.Name,
                        SlugName = h.SlugName,
                        AutoSlug = h.AutoSlug,
                        FkProductId = h.FkProductId,
                        Thumbnail = h.Thumbnail,
                        SortIndex = h.SortIndex,
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] ProductImageEditViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductImageController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(ProductImage);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.ProductImage
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
            if (await _webcontext.ProductImage.AnyAsync(h => h.Id != vmItem.Id && h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(ProductImage.Name), "The Name has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.ProductImage.AsNoTracking()
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
            dbItem.FkProductId = vmItem.FkProductId;
            dbItem.Thumbnail = vmItem.Thumbnail;
            dbItem.SortIndex = vmItem.SortIndex;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord = vmItem.KeyWord;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note = vmItem.Note;

            _webcontext.Entry(dbItem).Property(nameof(ProductImage.RowVersion)).OriginalValue = vmItem.RowVersion;
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

                var dbItem = await _webcontext.ProductImage.AsNoTracking()
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
            var tableName = nameof(ProductImage);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.ProductImage
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

                _webcontext.Entry(dbItem).Property(nameof(ProductImage.RowVersion)).OriginalValue = rowVersion;
                // Set time stamp for table to handle concurrency conflict
                tableVersion.LastModify = DateTime.Now;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }

        private async Task PrepareListMasterForeignKey(ProductImageBaseViewModel vm = null)
        {
            ViewData["FkProductId"] = new SelectList(
                await _webcontext.Product.AsNoTracking()
                    .Select(h => new { h.Id, h.Name })
                    .OrderByDescending(h => h.Name)
                    .ToListAsync(),
                "Id", "Name", vm?.FkProductId);
        }
    }

    public class ImageBrowserProductImageController : EditorImageBrowserController
    {
        public const string FOLDER_NAME = "ListProductImages";
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

        public ImageBrowserProductImageController(IHostingEnvironment hostingEnvironment, IConfiguration staticFileSetting)
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

    public class ProductImageBaseViewModel
    {
        public string Name { get; set; }
        public string SlugName { get; set; }
        public bool AutoSlug { get; set; }
        public string FkProductId { get; set; }
        public string Description { get; set; }
        public int SortIndex { get; set; }
        public bool IsYoutube { get; set; }
        public string YoutubeLink { get; set; }
        public string Thumbnail { get; set; }
        public string Note { get; set; }
        public string Tags { get; set; }
        public string KeyWord { get; set; }
        public string MetaData { get; set; }
    }

    public class ProductImageDetailsViewModel : ProductImageBaseViewModel
    {
        public string Id { get; set; }
        public string Extension { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public int RowStatus { get; set; }
        public int? Type { get; set; }
    }

    public class ProductImageCreateViewModel : ProductImageBaseViewModel
    {

    }

    public class ProductImageEditViewModel : ProductImageBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class ProductImageBaseValidator<T> : AtBaseValidator<T> where T : ProductImageBaseViewModel
    {
        public ProductImageBaseValidator()
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

            RuleFor(h => h.FkProductId)
                        .NotEmpty()
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Description)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.SortIndex)
                        .NotEmpty()
                ;

            RuleFor(h => h.YoutubeLink)
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Thumbnail)
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

    public class ProductImageCreateValidator : ProductImageBaseValidator<ProductImageCreateViewModel>
    {
        public ProductImageCreateValidator()
        {
        }
    }

    public class ProductImageEditValidator : ProductImageBaseValidator<ProductImageEditViewModel>
    {
        public ProductImageEditValidator()
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