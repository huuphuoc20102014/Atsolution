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
    public class CategoriesController : AtBaseController
    {
        private readonly AtECommerceContext _context;

        public CategoriesController(AtECommerceContext context, Microsoft.Extensions.Localization.IStringLocalizer<AtECommerce.SharedResources> Localizer)
        {
            _context = context;
            var a = Localizer["BtnCreateNew"];
        }

        // GET: Categories
        public IActionResult Index()
        {
            ViewData["ControllerNameForGrid"] = nameof(CategoriesController).Replace("Controller", "");
            return View();
        }

        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request)
        {
            var query = _context.Category.AsNoTracking()
                .Select(h => new CategoryDetailsViewModel
                {


                    Id = h.Id,
                    Code = h.Code,
                    Name = h.Name,
                    Slug_Name = h.Slug_Name,
                    AutoSlug = h.AutoSlug,
                    FkCategoryId = h.FkCategoryId,
                    // Ford
                    Rank = h.Rank,
                    SortIndex = h.SortIndex,
                    Tags = h.Tags,
                    KeyWord_Image = h.KeyWord_Image,
                    MetaData = h.MetaData,
                    Note_Html = h.Note_Html,
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
                Rank = vmItem.Rank,
                SortIndex = vmItem.SortIndex,
                Tags = vmItem.Tags,
                KeyWord_Image = vmItem.KeyWord_Image,
                MetaData = vmItem.MetaData,
                Note_Html = vmItem.Note_Html,
            };
            _context.Add(dbItem);

            // Set time stamp for table to handle concurrency conflict
            if (tableVersion != null)
            {
                tableVersion.LastModify = DateTime.Now;
            }
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
                    Rank = h.Rank,
                    SortIndex = h.SortIndex,
                    Tags = h.Tags,
                    KeyWord_Image = h.KeyWord_Image,
                    MetaData = h.MetaData,
                    Note_Html = h.Note_Html,
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
            dbItem.Rank = vmItem.Rank;
            dbItem.SortIndex = vmItem.SortIndex;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord_Image = vmItem.KeyWord_Image;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note_Html = vmItem.Note_Html;

            _context.Entry(dbItem).Property(nameof(Category.RowVersion)).OriginalValue = vmItem.RowVersion;

            // Set time stamp for table to handle concurrency conflict
            if (tableVersion != null)
            {
                tableVersion.LastModify = DateTime.Now;
            }
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


        public async Task<IActionResult> Sort([FromRoute] string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                id = null;
            }
            else
            {
                var dbItem = await _context.Category.AsNoTracking()
                    .Include(h => h.FkCategory)
                    .Where(h => h.Slug_Name == id)
                    .FirstOrDefaultAsync();
                ViewBag.ParentItem = dbItem;


                if (dbItem == null)
                {
                    return NotFound();
                }

                id = dbItem.Id;
            }
            
            var listDbItemChild = await _context.Category.AsNoTracking()
                .Where(h => h.FkCategoryId == id)
                .OrderBy(h => h.SortIndex).ThenBy(h => h.Name)
                .Select(h => new SortIndexViewModel
                {
                    Id = h.Id,
                    SortIndex = h.SortIndex,
                    Text = h.Code + " | " + h.Name
                })
                .ToListAsync();

            var messageFromPost = $"{TempData["Category_Sort_MessageFromPost"]}";
            if (!string.IsNullOrWhiteSpace(messageFromPost))
            {
                ModelState.AddModelError("", messageFromPost);
            }

            return View(listDbItemChild);
        }

        [HttpPost]
        public async Task<IActionResult> Sort([FromRoute] string id, [FromForm] List<SortIndexViewModel> vmItem)
        {
            var saveId = id;
            if (string.IsNullOrWhiteSpace(id))
            {
                id = null;
            }
            else
            {
                var dbItemId = await _context.Category.AsNoTracking()
                    .Where(h => h.Slug_Name == id)
                    .Select(h => h.Id)
                    .FirstAsync();

                if (dbItemId == null)
                {
                    return NotFound();
                }

                id = dbItemId;
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Category);
            var tableVersion = await _context.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var listDbItemChild = await _context.Category
                .Where(h => h.FkCategoryId == id)
                .OrderBy(h => h.SortIndex).ThenBy(h => h.Name)
                .ToListAsync();

            if (listDbItemChild.Count != vmItem.Count)
            {
                TempData["Category_Sort_MessageFromPost"] = "List items were changed. Please sort again.";
                return RedirectToAction(nameof(Sort), new { id });
            }


            vmItem = vmItem.OrderBy(h => h.SortIndex).ToList();
            var flagNeedSave = false;   

            // Update sort index
            for (int i = 0; i < vmItem.Count; i++)
            {
                var dbItem = listDbItemChild.FirstOrDefault(h => h.Id == vmItem[i].Id);

                if (dbItem.SortIndex != i)
                {
                    flagNeedSave = true;

                    dbItem.SortIndex = i;
                    dbItem.UpdatedBy = _loginUserId;
                    dbItem.UpdatedDate = DateTime.Now;
                }
            }

            if (flagNeedSave)
            {
                // Set time stamp for table to handle concurrency conflict
                if (tableVersion != null)
                {
                    tableVersion.LastModify = DateTime.Now;
                }
                await _context.SaveChangesAsync();

                TempData["Category_Sort_MessageFromPost"] = "Save success.";
            }
            else
            {
                TempData["Category_Sort_MessageFromPost"] = "Nothing changed.";
            }

            return RedirectToAction(nameof(Sort), new { id = saveId });
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
        public Int32 Rank { get; set; }
        public Int32 SortIndex { get; set; }
        public String Tags { get; set; }
        public String KeyWord_Image { get; set; }
        public String MetaData { get; set; }
        public String Note_Html { get; set; }
    }

    public class CategoryDetailsViewModel : CategoryBaseViewModel
    {

        public String Id { get; set; }
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

            RuleFor(h => h.Rank)
                ;

            RuleFor(h => h.SortIndex)
                ;

            RuleFor(h => h.Tags)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.KeyWord_Image)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.MetaData)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.Note_Html)
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
