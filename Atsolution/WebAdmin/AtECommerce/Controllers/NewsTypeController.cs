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
    public class NewsTypeController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;

        public NewsTypeController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }
        // GET: NewsType loại bài đănq
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                NewsType dbItem = null;
                if (!string.IsNullOrWhiteSpace(id))
                {
                    dbItem = await _webcontext.NewsType.AsNoTracking().FirstOrDefaultAsync(h => h.SlugName == id);
                    if (dbItem == null)
                    {
                        return NotFound();
                    }
                }
                ViewData["ParentItem"] = dbItem;

                ViewData["ControllerNameForGrid"] = nameof(NewsTypeController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request, string parentId)
        {
            var baseQuery = _webcontext.NewsType.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal);
            if (!string.IsNullOrWhiteSpace(parentId))
            {
                baseQuery = baseQuery.Where(h => h.Id == parentId);
            }
            var query = baseQuery
                .Select(h => new NewsTypeDetailsViewModel
                {
                    Id = h.Id,
                    Code = h.Code,
                    Name = h.Name,
                    Slug_Name = h.SlugName,
                    // Ford
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

        // GET: NewsType/Details/P
        public async Task<IActionResult> Details([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var NewsType = await _webcontext.NewsType.AsNoTracking()
                    .Where(h => h.SlugName == id)
                    .FirstOrDefaultAsync();
                if (NewsType == null)
                {
                    return NotFound();
                }

                return View(NewsType);
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        // GET: NewsType/Create
        public async Task<IActionResult> Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] NewsTypeCreateViewModel vmItem)
        {

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                //await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(NewsType);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(p => p.Id == tableName);
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
            if (await _webcontext.NewsType.AnyAsync(h => h.Code == vmItem.Code))
            {
                ModelState.AddModelError(nameof(NewsType.Code), "The code has been existed.");
                // Get list master of foreign property and set to view data
                // await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.Category.AsNoTracking()
                    .Where(h => h.SlugName.StartsWith(vmItem.Slug_Name))
                    .Select(h => h.SlugName).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Slug_Name, listExistedSlug);

            // Create save db item
            var dbItem = new NewsType
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
                SlugName = vmItem.Slug_Name,
                AutoSlug = vmItem.AutoSlug,
                Tags = vmItem.Tags,
                KeyWord = vmItem.KeyWord,
                MetaData = vmItem.MetaData,
                Note = vmItem.Note,
            };
            _webcontext.Add(dbItem);
            // Set time stamp for table to handle concurrency conflict     

            tableVersion.LastModify = DateTime.Now;

            await _webcontext.SaveChangesAsync();



            return RedirectToAction(nameof(Details), new { id = dbItem.SlugName });
        }

        // GET: NewsType/Edit/P
        public async Task<IActionResult> Edit([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var dbItem = await _webcontext.NewsType.AsNoTracking()
                            .Where(h => h.SlugName == id)

                    .Select(h => new NewsTypeEditViewModel
                    {
                        Id = h.Id,
                        Code = h.Code,
                        Name = h.Name,
                        Slug_Name = h.SlugName,
                        AutoSlug = h.AutoSlug,
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
                // await PrepareListMasterForeignKey(dbItem);

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
        public async Task<IActionResult> Edit([FromForm] NewsTypeEditViewModel vmItem)
        {
            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                //await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(NewsType);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.NewsType
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
            if (await _webcontext.NewsType.AnyAsync(h => h.Id != vmItem.Id && h.Code == vmItem.Code))
            {
                ModelState.AddModelError(nameof(NewsType.Code), "The code has been existed.");
                // Get list master of foreign property and set to view data
                //await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.NewsType.AsNoTracking()
                    .Where(h => h.Id != vmItem.Id && h.SlugName.StartsWith(vmItem.Slug_Name))
                    .Select(h => h.SlugName).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Slug_Name, listExistedSlug);

            // Update db item               
            dbItem.UpdatedBy = _loginUserId;
            dbItem.UpdatedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.Code = vmItem.Code;
            dbItem.Name = vmItem.Name;
            dbItem.SlugName = vmItem.Slug_Name;
            dbItem.AutoSlug = vmItem.AutoSlug;
            dbItem.Tags = vmItem.Tags;
            dbItem.KeyWord = vmItem.KeyWord;
            dbItem.MetaData = vmItem.MetaData;
            dbItem.Note = vmItem.Note;

            _webcontext.Entry(dbItem).Property(nameof(NewsType.RowVersion)).OriginalValue = vmItem.RowVersion;
            // Set time stamp for table to handle concurrency conflict
            tableVersion.LastModify = DateTime.Now;
            await _webcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.SlugName });
        }

        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var dbItem = await _webcontext.NewsType.AsNoTracking()
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
            var tableName = nameof(NewsType);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.NewsType
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

                _webcontext.Entry(dbItem).Property(nameof(NewsType.RowVersion)).OriginalValue = rowVersion;
                // Set time stamp for table to handle concurrency conflict
                tableVersion.LastModify = DateTime.Now;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }
    }


    public class NewsTypeBaseViewModel
    {

        public String Code { get; set; }
        public String Name { get; set; }
        public String Slug_Name { get; set; }
        public Boolean AutoSlug { get; set; }
        public String Tags { get; set; }
        public String KeyWord { get; set; }
        public String MetaData { get; set; }
        public String Note { get; set; }
    }
    public class NewsTypeDetailsViewModel : NewsTypeBaseViewModel
    {

        public String Id { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }

    }
    public class NewsTypeCreateViewModel : NewsTypeBaseViewModel
    {

    }
    public class NewsTypeEditViewModel : NewsTypeBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }
    public class NewsTypeBaseValidator<T> : AtBaseValidator<T> where T : NewsTypeBaseViewModel
    {
        public NewsTypeBaseValidator()
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

    public class NewsTypeCreateValidator : NewsTypeBaseValidator<NewsTypeCreateViewModel>
    {
        public NewsTypeCreateValidator()
        {
        }
    }

    public class NewsTypeEditValidator : NewsTypeBaseValidator<NewsTypeEditViewModel>
    {
        public NewsTypeEditValidator()
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