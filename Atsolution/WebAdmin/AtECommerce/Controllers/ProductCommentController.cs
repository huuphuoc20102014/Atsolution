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

namespace AtECommerce.Controllers
{
    public class ProductCommentController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;
        public ProductCommentController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                ProductComment dbItem = null;
                if (!string.IsNullOrWhiteSpace(id))
                {
                    dbItem = await _webcontext.ProductComment.AsNoTracking().FirstOrDefaultAsync(h => h.Id == id);
                    if (dbItem == null)
                    {
                        return NotFound();
                    }
                }
                ViewData["ParentItem"] = dbItem;

                ViewData["ControllerNameForGrid"] = nameof(ProductCommentController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request, string parentId)
        {
            var baseQuery = _webcontext.ProductComment.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal);
            if (!string.IsNullOrWhiteSpace(parentId))
            {
                baseQuery = baseQuery.Where(h => h.Id == parentId);
            }
            var query = baseQuery
                .Select(h => new ProductCommentDetailsViewModel
                {
                    Id = h.Id,
                    FkProductId = h.FkProductId,
                    Name = h.Name,
                    Email = h.Email,
                    Phone = h.Phone,
                    Comment = h.Comment,
                    Rating = h.Rating,
                    IsRead = h.IsRead,
                    Note = h.Note,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    UpdatedBy = h.UpdatedBy,
                    UpdatedDate = h.UpdatedDate,
                    RowVersion = h.RowVersion,
                    RowStatus = (AtRowStatus)h.RowStatus,
                    CountReply = 0,

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

                var ProductComment = await _webcontext.ProductComment.AsNoTracking()

                    .Include(c => c.FkProductComment)
                        .Where(h => h.Id == id)
                    .FirstOrDefaultAsync();
                if (ProductComment == null)
                {
                    return NotFound();
                }

                return View(ProductComment);
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
        public async Task<IActionResult> Create([FromForm] ProductCommentCreateViewModel vmItem)
        {
            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(ProductComment);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(p => p.Id == tableName);

            // Check Name is existed
            if (await _webcontext.ProductComment.AnyAsync(h => h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(ProductComment.Name), "The Name has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }


            // Create save db item
            var dbItem = new ProductComment
            {
                Id = Guid.NewGuid().ToString(),

                CreatedBy = _loginUserId,
                CreatedDate = DateTime.Now,
                UpdatedBy = null,
                UpdatedDate = null,
                RowStatus = (int)AtRowStatus.Normal,
                RowVersion = null,

                FkProductId = vmItem.FkProductId,
                Name = vmItem.Name,
                Email = vmItem.Email,
                Phone = vmItem.Phone,
                Comment = vmItem.Comment,
                Rating = vmItem.Rating,
                IsRead = vmItem.IsRead,
                Note = vmItem.Note,
                CountReply = 0
            };
            _webcontext.Add(dbItem);
            // Set time stamp for table to handle concurrency conflict     

            tableVersion.LastModify = DateTime.Now;

            await _webcontext.SaveChangesAsync();



            return RedirectToAction(nameof(Details), new { id = dbItem.Id });
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

                var dbItem = await _webcontext.ProductComment.AsNoTracking()
                    .Where(h => h.Id == id)
                     .Select(h => new ProductCommentEditViewModel
                     {
                         Id = h.Id,
                         FkProductId = h.FkProductId,
                         Name = h.Name,
                         Email = h.Email,
                         Phone = h.Phone,
                         Comment = h.Comment,
                         Rating = h.Rating,
                         IsRead = h.IsRead,
                         Note = h.Note,
                         RowVersion = h.RowVersion,
                         CountReply = 0
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
        public async Task<IActionResult> Edit([FromForm] ProductCommentEditViewModel vmItem)
        {

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(ProductComment);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.ProductComment
                .Where(h => h.Id == vmItem.Id)

                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            // Trim white space
            vmItem.Name = $"{vmItem.Name}".Trim();

            // Check Name is existed
            if (await _webcontext.ProductComment.AnyAsync(h => h.Id != vmItem.Id && h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(ProductComment.Name), "The Name has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Update db item               
            dbItem.UpdatedBy = _loginUserId;
            dbItem.UpdatedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.FkProductId = vmItem.FkProductId;
            dbItem.Name = vmItem.Name;
            dbItem.Email = vmItem.Email;
            dbItem.Phone = vmItem.Phone;
            dbItem.Comment = vmItem.Comment;
            dbItem.Rating = vmItem.Rating;
            dbItem.IsRead = vmItem.IsRead;
            dbItem.Note = vmItem.Note;
            dbItem.CountReply = 0;

            _webcontext.Entry(dbItem).Property(nameof(ProductComment.RowVersion)).OriginalValue = vmItem.RowVersion;
            // Set time stamp for table to handle concurrency conflict
            tableVersion.LastModify = DateTime.Now;
            await _webcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.Id });
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

                var dbItem = await _webcontext.ProductComment.AsNoTracking()

                    .Include(c => c.FkProductComment)
                        .Where(h => h.Id == id)
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
            var tableName = nameof(ProductComment);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.ProductComment

                .Include(c => c.FkProductComment)
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

                _webcontext.Entry(dbItem).Property(nameof(ProductComment.RowVersion)).OriginalValue = rowVersion;
                // Set time stamp for table to handle concurrency conflict
                tableVersion.LastModify = DateTime.Now;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }

        private async Task PrepareListMasterForeignKey(ProductCommentBaseViewModel vm = null)
        {
            ViewData["FkProductId"] = new SelectList(
                await _webcontext.Product.AsNoTracking()
                    .Select(h => new { h.Id, h.Name })
                    .OrderBy(h => h.Name)
                    .ToListAsync(),
                "Id", "Name", vm?.FkProductId);
        }
    }

    public class ProductCommentBaseViewModel
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String FkProductId { get; set; }
        public String Comment { get; set; }
        public Int32 Rating { get; set; }
        public Boolean IsRead { get; set; }
        public String Note { get; set; }
        public Int32 CountReply { get; set; }
    }

    public class ProductCommentDetailsViewModel : ProductCommentBaseViewModel
    {
        public String Id { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }
    }

    public class ProductCommentCreateViewModel : ProductCommentBaseViewModel
    {

    }

    public class ProductCommentEditViewModel : ProductCommentBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class ProductCommentBaseValidator<T> : AtBaseValidator<T> where T : ProductCommentBaseViewModel
    {
        public ProductCommentBaseValidator()
        {
            RuleFor(h => h.FkProductId)
                        .NotEmpty()
                ;

            RuleFor(h => h.Name)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Email)
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Phone)
                        .MaximumLength(20)
                ;

            RuleFor(h => h.Comment)
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.Rating)
                        .NotEmpty()
                ;

            RuleFor(h => h.Note)
                        .MaximumLength(1000)
                ;
        }
    }

    public class ProductCommentCreateValidator : ProductCommentBaseValidator<ProductCommentCreateViewModel>
    {
        public ProductCommentCreateValidator()
        {
        }
    }

    public class ProductCommentEditValidator : ProductCommentBaseValidator<ProductCommentEditViewModel>
    {
        public ProductCommentEditValidator()
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