﻿using System;
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
using Kendo.Mvc.TagHelpers;

namespace AtECommerce.Controllers
{
    public class ProductsController : AtBaseController
    {
        private readonly AtECommerceContext _context;

        public ProductsController(AtECommerceContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult Index()
        {
            ViewData["ControllerNameForGrid"] = nameof(ProductsController).Replace("Controller", "");
            return View();
        }

        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request)
        {
            var query = _context.Product.AsNoTracking()
                .Select(h => new ProductDetailsViewModel
                {


                    Id = h.Id,
                    Code = h.Code,
                    Name = h.Name,
                    Slug_Name = h.Slug_Name,
                    AutoSlug = h.AutoSlug,
                    FkProductId = h.FkProductId,
                    // Ford
                    Specification_Html = h.Specification_Html,
                    ShortDescription_Html = h.ShortDescription_Html,
                    LongDescription_Html = h.LongDescription_Html,
                    SKU = h.SKU,
                    Color = h.Color,
                    Size = h.Size,
                    Material = h.Material,
                    Style = h.Style,
                    Price = h.Price,
                    CCY = h.CCY,
                    Country = h.Country,
                    Producer = h.Producer,
                    Status = h.Status,
                    ImageSlug = h.ImageSlug,
                    Rating = h.Rating,
                    CountView = h.CountView,
                    IsService = h.IsService,
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
                    CountComment = h.CountComment,
                    CountReply = h.CountReply,

                });

            return Json(await query.ToDataSourceResultAsync(request));
        }


        // GET: Products/Details/5
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.AsNoTracking()

                .Include(p => p.FkProduct)
                    .Where(h => h.Slug_Name == id)
                .FirstOrDefaultAsync();
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public async Task<IActionResult> Create()
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductController).Replace("Controller", "");
            // Get list master of foreign property and set to view data
            await PrepareListMasterForeignKey();

            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] ProductCreateViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Product);
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
            if (await _context.Product.AnyAsync(h => h.Code == vmItem.Code))
            {
                ModelState.AddModelError(nameof(Product.Code), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _context.Product.AsNoTracking()
                    .Where(h => h.Slug_Name.StartsWith(vmItem.Slug_Name))
                    .Select(h => h.Slug_Name).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Slug_Name, listExistedSlug);

            // Create save db item
            var dbItem = new Product
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
                FkProductId = vmItem.FkProductId,
                Specification_Html = vmItem.Specification_Html,
                ShortDescription_Html = vmItem.ShortDescription_Html,
                LongDescription_Html = vmItem.LongDescription_Html,
                SKU = vmItem.SKU,
                Color = vmItem.Color,
                Size = vmItem.Size,
                Material = vmItem.Material,
                Style = vmItem.Style,
                Price = vmItem.Price,
                CCY = vmItem.CCY,
                Country = vmItem.Country,
                Producer = vmItem.Producer,
                Status = vmItem.Status,
                ImageSlug = vmItem.ImageSlug,
                Rating = vmItem.Rating,
                CountView = vmItem.CountView,
                IsService = vmItem.IsService,
                Tags = vmItem.Tags,
                KeyWord = vmItem.KeyWord,
                MetaData = vmItem.MetaData,
                Note = vmItem.Note,
                CountComment = vmItem.CountComment,
                CountReply = vmItem.CountReply,
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

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit([FromRoute] string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductController).Replace("Controller", "");

            var dbItem = await _context.Product.AsNoTracking()

    .Where(h => h.Slug_Name == id)

                .Select(h => new ProductEditViewModel
                {
                    Id = h.Id,
                    Code = h.Code,
                    Name = h.Name,
                    Slug_Name = h.Slug_Name,
                    AutoSlug = h.AutoSlug,
                    FkProductId = h.FkProductId,
                    Specification_Html = h.Specification_Html,
                    ShortDescription_Html = h.ShortDescription_Html,
                    LongDescription_Html = h.LongDescription_Html,
                    SKU = h.SKU,
                    Color = h.Color,
                    Size = h.Size,
                    Material = h.Material,
                    Style = h.Style,
                    Price = h.Price,
                    CCY = h.CCY,
                    Country = h.Country,
                    Producer = h.Producer,
                    Status = h.Status,
                    ImageSlug = h.ImageSlug,
                    Rating = h.Rating,
                    CountView = h.CountView,
                    IsService = h.IsService,
                    Tags = h.Tags,
                    KeyWord = h.KeyWord,
                    MetaData = h.MetaData,
                    Note = h.Note,
                    RowVersion = h.RowVersion,
                    CountComment = h.CountComment,
                    CountReply = h.CountReply,
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

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] ProductEditViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserProductController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Product);
            var tableVersion = await _context.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _context.Product
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
            if (await _context.Product.AnyAsync(h => h.Id != vmItem.Id && h.Code == vmItem.Code))
            {
                ModelState.AddModelError(nameof(Product.Code), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _context.Product.AsNoTracking()
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
            dbItem.FkProductId = vmItem.FkProductId;
            dbItem.Specification_Html = vmItem.Specification_Html;
            dbItem.ShortDescription_Html = vmItem.ShortDescription_Html;
            dbItem.LongDescription_Html = vmItem.LongDescription_Html;
            dbItem.SKU = vmItem.SKU;
            dbItem.Color = vmItem.Color;
            dbItem.Size = vmItem.Size;
            dbItem.Material = vmItem.Material;
            dbItem.Style = vmItem.Style;
            dbItem.Price = vmItem.Price;
            dbItem.CCY = vmItem.CCY;
            dbItem.Country = vmItem.Country;
            dbItem.Producer = vmItem.Producer;
            dbItem.Status = vmItem.Status;
            dbItem.ImageSlug = vmItem.ImageSlug;
            dbItem.Rating = vmItem.Rating;
            dbItem.CountView = vmItem.CountView;
            dbItem.IsService = vmItem.IsService;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord = vmItem.KeyWord;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note = vmItem.Note;
            dbItem.CountComment = vmItem.CountComment;
            dbItem.CountReply = vmItem.CountReply;

            _context.Entry(dbItem).Property(nameof(Product.RowVersion)).OriginalValue = vmItem.RowVersion;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.Slug_Name });
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbItem = await _context.Product.AsNoTracking()

                .Include(p => p.FkProduct)
                    .Where(h => h.Slug_Name == id)
                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            return View(dbItem);
        }

        // POST: Products/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromForm] string id, [FromForm] byte[] rowVersion)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbItem = await _context.Product

                .Include(p => p.FkProduct)
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

                _context.Entry(dbItem).Property(nameof(Product.RowVersion)).OriginalValue = rowVersion;
                await _context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }

        private async Task PrepareListMasterForeignKey(ProductBaseViewModel vm = null)
        {
            ViewData["FkProductId"] = new SelectList(
                await _context.Category.AsNoTracking()
                    .Select(h => new { h.Id, h.Name })
                    .OrderByDescending(h => h.Name)
                    .ToListAsync(),
                "Id", "Name", vm?.FkProductId);


            DropDownTreeItemModel selectedTreeItem = null;

            var listDbItem = await _context.Category.AsNoTracking()
                    .Select(h => new { h.Id, h.Code, h.Name, ParentId = h.FkCategoryId })
                    .OrderBy(h => h.Name)
                    .ToListAsync();

            var listTreeItemRoot = new List<DropDownTreeItemModel>(listDbItem.Count);
            // First get the root
            for (int i = listDbItem.Count - 1; i >= 0; i--)
            {
                var dbItem = listDbItem[i];
                if (string.IsNullOrWhiteSpace(dbItem.ParentId))
                {
                    var itemModel = new DropDownTreeItemModel
                    {
                        Id = dbItem.Id,
                        Value = dbItem.Id,
                        Text = $"{dbItem.Code} | {dbItem.Name}",
                        Expanded = true,
                        Selected = vm != null && vm.FkProductId == dbItem.Id
                    };
                    listTreeItemRoot.Add(itemModel);
                    listDbItem.RemoveAt(i);
                    if (itemModel.Selected)
                    {
                        selectedTreeItem = itemModel;
                    }
                }
            }

            var listTreeItemParent = listTreeItemRoot.ToList();
            while (listDbItem.Count > 0)
            {
                var flagHitParent = false;
                foreach (var itemParent in listTreeItemParent)
                {
                    var listChildren = new List<DropDownTreeItemModel>(listDbItem.Count);
                    itemParent.Items = listChildren;

                    for (int i = listDbItem.Count - 1; i >= 0; i--)
                    {
                        var dbItem = listDbItem[i];
                        if (dbItem.ParentId == itemParent.Value)
                        {
                            flagHitParent = true;

                            var itemModel = new DropDownTreeItemModel
                            {
                                Id = dbItem.Id,
                                Value = dbItem.Id,
                                Text = $"{dbItem.Code} | {dbItem.Name}",
                                Expanded = true,
                                Selected = vm != null && vm.FkProductId == dbItem.Id
                            };
                            listChildren.Add(itemModel);
                            listDbItem.RemoveAt(i);
                            if (itemModel.Selected)
                            {
                                selectedTreeItem = itemModel;
                            }
                        }
                    }
                }

                // Truong hop db bi loi, tat cac cac item trong list deu ko tim thay item cha
                if (!flagHitParent)
                {
                    break;
                }

                listTreeItemParent = listTreeItemParent.SelectMany(h => h.Items).ToList();
            }

            ViewData["FkProductId"] = listTreeItemRoot;
            ViewData["FkProductId_SelectedItem"] = selectedTreeItem;
        }





    }



    public class ImageBrowserProductController : EditorImageBrowserController
    {
        public const string FOLDER_NAME = "ImagesProduct";

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

        public ImageBrowserProductController(IHostingEnvironment hostingEnvironment)
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


    public class ProductBaseViewModel
    {

        public String Code { get; set; }
        public String Name { get; set; }
        public String Slug_Name { get; set; }
        public Boolean AutoSlug { get; set; }
        public String FkProductId { get; set; }
        public String Specification_Html { get; set; }
        public String ShortDescription_Html { get; set; }
        public String LongDescription_Html { get; set; }
        public String SKU { get; set; }
        public String Color { get; set; }
        public String Size { get; set; }
        public String Material { get; set; }
        public String Style { get; set; }
        public Double? Price { get; set; }
        public String CCY { get; set; }
        public String Country { get; set; }
        public String Producer { get; set; }
        public String Status { get; set; }
        public String ImageSlug { get; set; }
        public Int32? Rating { get; set; }
        public Int32? CountView { get; set; }
        public Boolean IsService { get; set; }
        public String Tags { get; set; }
        public String KeyWord { get; set; }
        public String MetaData { get; set; }
        public String Note { get; set; }
        public Int32 CountComment { get; set; }
        public Int32 CountReply { get; set; }
    }

    public class ProductDetailsViewModel : ProductBaseViewModel
    {

        public String Id { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }


        public string FkProduct_Code { get; set; }
        public string FkProduct_Name { get; set; }
        public string FkProduct_Slug_Name { get; set; }

    }

    public class ProductCreateViewModel : ProductBaseViewModel
    {

    }

    public class ProductEditViewModel : ProductBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class ProductBaseValidator<T> : AtBaseValidator<T> where T : ProductBaseViewModel
    {
        public ProductBaseValidator()
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

            RuleFor(h => h.FkProductId)
                        .NotEmpty()
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Specification_Html)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.ShortDescription_Html)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.LongDescription_Html)
                ;

            RuleFor(h => h.SKU)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Color)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Size)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Material)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Style)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Price)
                ;

            RuleFor(h => h.CCY)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Country)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Producer)
                        .MaximumLength(500)
                ;

            RuleFor(h => h.Status)
                        .MaximumLength(50)
                ;

            RuleFor(h => h.ImageSlug)
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Rating)
                ;

            RuleFor(h => h.CountView)
                ;

            RuleFor(h => h.IsService)
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

            RuleFor(h => h.CountComment)
                ;

            RuleFor(h => h.CountReply)
                ;

        }
    }

    public class ProductCreateValidator : ProductBaseValidator<ProductCreateViewModel>
    {
        public ProductCreateValidator()
        {
        }
    }

    public class ProductEditValidator : ProductBaseValidator<ProductEditViewModel>
    {
        public ProductEditValidator()
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