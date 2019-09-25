using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AtECommerce.Efs.Entities;
using FluentValidation;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Hosting;

using AtECommerce.Efs.Entities;




namespace AtECommerce.Controllers
{
    //Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore.NavigationMetadata
    //FkCategory
    //FkCategoryId
    public class CategoriesController : AtBaseController
    {
        private readonly AtECommerceContext _context;

        public CategoriesController(AtECommerceContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            Category dbItem = null;
            if (!string.IsNullOrWhiteSpace(id))
            {
                dbItem = await _context.Category.AsNoTracking().FirstOrDefaultAsync(h => h.Slug_Name == id);
                if (dbItem == null)
                {
                    return NotFound();
                }
            }
            ViewData["ParentItem"] = dbItem;

            ViewData["ControllerNameForGrid"] = nameof(CategoriesController).Replace("Controller", "");
            return View();
        }

        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request, string parentId)
        {
            var baseQuery = _context.Category.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(parentId))
            {
                baseQuery = baseQuery.Where(h => h.FkCategoryId == parentId);
            }
            var query = baseQuery
                .Select(h => new CategoryDetailsViewModel
                {
                    Id = h.Id,
                    Code = h.Code,
                    Name = h.Name,
                    Slug_Name = h.Slug_Name,
                    FkCategoryId = h.FkCategoryId,
                    // Ford
                    Thumbnail_Image = h.Thumbnail_Image,
                    SortIndex = h.SortIndex,
                    Rank_ReadOnly = h.Rank_ReadOnly,
                    Tags = h.Tags,
                    KeyWord = h.KeyWord,
                    MetaData = h.MetaData,
                    Note_Multiline = h.Note_Multiline,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    UpdatedBy = h.UpdatedBy,
                    UpdatedDate = h.UpdatedDate,
                    RowVersion = h.RowVersion,
                    RowStatus = (AtRowStatus)h.RowStatus,
                    CountChild_ReadOnly = h.CountChild_ReadOnly,
                    CountProduct_ReadOnly = h.CountProduct_ReadOnly,

                });

            return Json(await query.ToDataSourceResultAsync(request));
        }


        // GET: Categories/Details/5
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.AsNoTracking()

                .Include(c => c.FkCategory)
                    .Where(h => h.Slug_Name == id)
                .FirstOrDefaultAsync();
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public async Task<IActionResult> Create()
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserCategoryController).Replace("Controller", "");
            // Get list master of foreign property and set to view data
            await PrepareListMasterForeignKey();

            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] CategoryCreateViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserCategoryController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Category);
            var tableVersion = await _context.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            // Trim white space
            vmItem.Code = $"{vmItem.Code}".Trim();
            vmItem.Name = $"{vmItem.Name}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.Slug_Name = NormalizeSlug($"{vmItem.Name}");
            }
            else
            {
                vmItem.Slug_Name = NormalizeSlug($"{vmItem.Slug_Name}");
            }

            // Check code is existed
            if (await _context.Category.AnyAsync(h => h.Code == vmItem.Code))
            {
                ModelState.AddModelError(nameof(Category.Code), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _context.Category.AsNoTracking()
                    .Where(h => h.Slug_Name.StartsWith(vmItem.Slug_Name))
                    .Select(h => h.Slug_Name).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Slug_Name, listExistedSlug);

            // Create save db item
            var dbItem = new Category
            {
                Id = Guid.NewGuid().ToString(),

                CreatedBy = _loginUserId,
                CreatedDate = DateTime.Now,
                UpdatedBy = null,
                UpdatedDate = null,
                RowStatus = (int)AtRowStatus.Normal,
                RowVersion = null,

                Code = vmItem.Code,
                Name = vmItem.Name,
                Slug_Name = vmItem.Slug_Name,
                AutoSlug = vmItem.AutoSlug,
                FkCategoryId = vmItem.FkCategoryId,
                Thumbnail_Image = vmItem.Thumbnail_Image,
                SortIndex = vmItem.SortIndex,
                Tags = vmItem.Tags,
                KeyWord = vmItem.KeyWord,
                MetaData = vmItem.MetaData,
                Note_Multiline = vmItem.Note_Multiline,
            };
            _context.Add(dbItem);

            // Set time stamp for table to handle concurrency conflict
            tableVersion.LastModify = DateTime.Now;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.Slug_Name });
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit([FromRoute] string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserCategoryController).Replace("Controller", "");

            var dbItem = await _context.Category.AsNoTracking()

    .Where(h => h.Slug_Name == id)

                .Select(h => new CategoryEditViewModel
                {
                    Id = h.Id,
                    Code = h.Code,
                    Name = h.Name,
                    Slug_Name = h.Slug_Name,
                    AutoSlug = h.AutoSlug,
                    FkCategoryId = h.FkCategoryId,
                    Thumbnail_Image = h.Thumbnail_Image,
                    SortIndex = h.SortIndex,
                    Tags = h.Tags,
                    KeyWord = h.KeyWord,
                    MetaData = h.MetaData,
                    Note_Multiline = h.Note_Multiline,
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

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] CategoryEditViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserCategoryController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Category);
            var tableVersion = await _context.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _context.Category
                .Where(h => h.Id == vmItem.Id)

                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            // Trim white space
            vmItem.Code = $"{vmItem.Code}".Trim();
            vmItem.Name = $"{vmItem.Name}".Trim();
            if (vmItem.AutoSlug)
            {
                vmItem.Slug_Name = NormalizeSlug($"{vmItem.Name}");
            }
            else
            {
                vmItem.Slug_Name = NormalizeSlug($"{vmItem.Slug_Name}");
            }

            // Check code is existed
            if (await _context.Category.AnyAsync(h => h.Id != vmItem.Id && h.Code == vmItem.Code))
            {
                ModelState.AddModelError(nameof(Category.Code), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _context.Category.AsNoTracking()
                    .Where(h => h.Id != vmItem.Id && h.Slug_Name.StartsWith(vmItem.Slug_Name))
                    .Select(h => h.Slug_Name).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Slug_Name, listExistedSlug);

            // Update db item               
            dbItem.UpdatedBy = _loginUserId;
            dbItem.UpdatedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.Code = vmItem.Code;
            dbItem.Name = vmItem.Name;
            dbItem.Slug_Name = vmItem.Slug_Name;
            dbItem.AutoSlug = vmItem.AutoSlug;
            dbItem.FkCategoryId = vmItem.FkCategoryId;
            dbItem.Thumbnail_Image = vmItem.Thumbnail_Image;
            dbItem.SortIndex = vmItem.SortIndex;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord = vmItem.KeyWord;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note_Multiline = vmItem.Note_Multiline;

            _context.Entry(dbItem).Property(nameof(Category.RowVersion)).OriginalValue = vmItem.RowVersion;
            // Set time stamp for table to handle concurrency conflict
            tableVersion.LastModify = DateTime.Now;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.Slug_Name });
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbItem = await _context.Category.AsNoTracking()

                .Include(c => c.FkCategory)
                    .Where(h => h.Slug_Name == id)
                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            return View(dbItem);
        }

        // POST: Categories/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromForm] string id, [FromForm] byte[] rowVersion)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Category);
            var tableVersion = await _context.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _context.Category

                .Include(c => c.FkCategory)
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

                _context.Entry(dbItem).Property(nameof(Category.RowVersion)).OriginalValue = rowVersion;
                // Set time stamp for table to handle concurrency conflict
                tableVersion.LastModify = DateTime.Now;
                await _context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }

        private async Task PrepareListMasterForeignKey(CategoryBaseViewModel vm = null)
        {
            ViewData["FkCategoryId"] = new SelectList(
                await _context.Category.AsNoTracking()
                    .Select(h => new { h.Id, h.Name })
                    .OrderBy(h => h.Name)
                    .ToListAsync(),
                "Id", "Name", vm?.FkCategoryId);
        }
    }

    public class ImageBrowserCategoryController : EditorImageBrowserController
    {
        public const string FOLDER_NAME = "ImagesCategory";

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

        public ImageBrowserCategoryController(IHostingEnvironment hostingEnvironment)
            : base(hostingEnvironment)
        {
        }
        private string CreateUserFolder()
        {
            var virtualPath = System.IO.Path.Combine(FOLDER_NAME);
            var path = HostingEnvironment.WebRootFileProvider.GetFileInfo(virtualPath).PhysicalPath;

            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            return virtualPath;
        }
    }


    public class CategoryBaseViewModel
    {

        public String Code { get; set; }
        public String Name { get; set; }
        public String Slug_Name { get; set; }
        public Boolean AutoSlug { get; set; }
        public String FkCategoryId { get; set; }
        public String Thumbnail_Image { get; set; }
        public Int32 SortIndex { get; set; }
        public String Tags { get; set; }
        public String KeyWord { get; set; }
        public String MetaData { get; set; }
        public String Note_Multiline { get; set; }
    }

    public class CategoryDetailsViewModel : CategoryBaseViewModel
    {

        public String Id { get; set; }
        public Int32 Rank_ReadOnly { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }
        public Int32 CountChild_ReadOnly { get; set; }
        public Int32 CountProduct_ReadOnly { get; set; }


        public string FkCategory_Code { get; set; }
        public string FkCategory_Name { get; set; }
        public string FkCategory_Slug_Name { get; set; }

    }

    public class CategoryCreateViewModel : CategoryBaseViewModel
    {

    }

    public class CategoryEditViewModel : CategoryBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class CategoryBaseValidator<T> : AtBaseValidator<T> where T : CategoryBaseViewModel
    {
        public CategoryBaseValidator()
        {
            RuleFor(h => h.Code)
                        .NotEmpty()
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Name)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Slug_Name)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.AutoSlug)
                ;

            RuleFor(h => h.FkCategoryId)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Thumbnail_Image)
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

            RuleFor(h => h.Note_Multiline)
                        .MaximumLength(1000)
                ;

        }
    }

    public class CategoryCreateValidator : CategoryBaseValidator<CategoryCreateViewModel>
    {
        public CategoryCreateValidator()
        {
        }
    }

    public class CategoryEditValidator : CategoryBaseValidator<CategoryEditViewModel>
    {
        public CategoryEditValidator()
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
