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

namespace AtECommerce.Controllers
{
    public class ContactController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;

        public ContactController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }

        //GET data from db
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                Contact dbItem = null;
                if (!string.IsNullOrWhiteSpace(id))
                {
                    dbItem = await _webcontext.Contact.AsNoTracking().FirstOrDefaultAsync(h => h.Id == id);
                    if (dbItem == null)
                    {
                        return NotFound();
                    }
                }
                ViewData["ParentItem"] = dbItem;

                ViewData["ControllerNameForGrid"] = nameof(ContactController).Replace("Controller", "");
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
            var query = _webcontext.Contact.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal) //rowstatus == 0
                .Select(h => new ContactDetailsViewModel
                {
                    Id = h.Id,
                    Name = h.Name,
                    Email = h.Email,
                    Phone = h.Phone,
                    Title = h.Title,
                    Body = h.Body,
                    IsRead = h.IsRead,
                    FkProductCommentId = h.FkProductCommentId,
                    Note = h.Note,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    UpdatedBy = h.UpdatedBy,
                    UpdatedDate = h.UpdatedDate,
                    RowVersion = h.RowVersion,
                    RowStatus = (AtRowStatus)h.RowStatus,
                    Map = h.Map
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

                var contact = await _webcontext.Contact.AsNoTracking()
                        .Where(h => h.Id == id)
                    .FirstOrDefaultAsync();
                if (contact == null)
                {
                    return NotFound();
                }

                return View(contact);
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
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] ContactCreateViewModel vmItem)
        {

            // Invalid model
            if (!ModelState.IsValid)
            {
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Contact);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(p => p.Id == tableName);
            // Trim white space
            vmItem.Name = $"{vmItem.Name}".Trim();
            if (vmItem.IsRead)
            {
                vmItem.Title = NormalizeSlug($"{vmItem.Name}");
            }
            else
            {
                vmItem.Title = NormalizeSlug($"{vmItem.Title}");
            }

            // Check code is existed
            if (await _webcontext.Contact.AnyAsync(h => h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(Contact.Name), "The name has been existed.");
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.Contact.AsNoTracking()
                    .Where(h => h.Name.StartsWith(vmItem.Name))
                    .Select(h => h.Name).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Name, listExistedSlug);

            // Create save db item
            var dbItem = new Contact
            {
                Id = Guid.NewGuid().ToString(),
                Name = vmItem.Name,
                Email = vmItem.Email,
                Phone = vmItem.Phone,
                Title = vmItem.Title,
                Body = vmItem.Body,
                IsRead = vmItem.IsRead,
                FkProductCommentId = null,
                Note = vmItem.Note,
                CreatedBy = _loginUserId,
                CreatedDate = DateTime.Now,
                UpdatedBy = null,
                UpdatedDate = null,
                RowVersion = null,
                RowStatus = (int)AtRowStatus.Normal,
                Map = vmItem.Map,

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

                var dbItem = await _webcontext.Contact.AsNoTracking()
                    .Where(h => h.Id == id)
                    .Select(h => new ContactEditViewModel
                    {
                        Id = h.Id,
                        Name = h.Name,
                        Email = h.Email,
                        Phone = h.Phone,
                        Title = h.Title,
                        Body = h.Body,
                        IsRead = h.IsRead,
                        Note = h.Note,
                        RowVersion = h.RowVersion,
                        Map = h.Map,

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
        public async Task<IActionResult> Edit([FromForm] ContactEditViewModel vmItem)
        {

            // Invalid model
            if (!ModelState.IsValid)
            {
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(Contact);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.Contact
                .Where(h => h.Id == vmItem.Id)

                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            // Trim white space
            vmItem.Name = $"{vmItem.Name}".Trim();
            if (vmItem.IsRead)
            {
                vmItem.Title = NormalizeSlug($"{vmItem.Name}");
            }
            else
            {
                vmItem.Title = NormalizeSlug($"{vmItem.Title}");
            }

            // Check code is existed
            if (await _webcontext.Contact.AnyAsync(h => h.Id != vmItem.Id && h.Name == vmItem.Name))
            {
                ModelState.AddModelError(nameof(Contact.Name), "The name has been existed.");
                return View(vmItem);
            }

            // Check slug is existed => if existed auto get next slug
            var listExistedSlug = await _webcontext.Contact.AsNoTracking()
                    .Where(h => h.Id != vmItem.Id && h.Name.StartsWith(vmItem.Name))
                    .Select(h => h.Name).ToListAsync();
            var slug = CheckAndGenNextSlug(vmItem.Name, listExistedSlug);

            // Update db item               
            dbItem.UpdatedBy = _loginUserId;
            dbItem.UpdatedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.Name = vmItem.Name;
            dbItem.Email = vmItem.Email;
            dbItem.Phone = vmItem.Phone;
            dbItem.Title = vmItem.Title;
            dbItem.Body = vmItem.Body;
            dbItem.IsRead = vmItem.IsRead;
            dbItem.Note = vmItem.Note;

            _webcontext.Entry(dbItem).Property(nameof(Contact.RowVersion)).OriginalValue = vmItem.RowVersion;
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

                var dbItem = await _webcontext.Contact.AsNoTracking()
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
            var tableName = nameof(Contact);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.Contact
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

                _webcontext.Entry(dbItem).Property(nameof(Contact.RowVersion)).OriginalValue = rowVersion;
                // Set time stamp for table to handle concurrency conflict
                tableVersion.LastModify = DateTime.Now;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }
    }

    public class ContactBaseViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsRead { get; set; }
        public string Note { get; set; }
        public string Map { get; set; }
    }

    public class ContactDetailsViewModel : ContactBaseViewModel
    {
        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }
        public string FkProductCommentId { get; set; }
    }

    public class ContactCreateViewModel : ContactBaseViewModel
    {

    }

    public class ContactEditViewModel : ContactBaseViewModel
    {

        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }

    public class ContactBaseValidator<T> : AtBaseValidator<T> where T : ContactBaseViewModel
    {
        public ContactBaseValidator()
        {
            RuleFor(h => h.Name)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Email)
                        .NotEmpty()
                        .MaximumLength(50)
                ;

            RuleFor(h => h.Phone)
                        .NotEmpty()
                        .MaximumLength(20)
                ;

            RuleFor(h => h.Title)
                        .NotEmpty()
                        .MaximumLength(100)
                ;

            RuleFor(h => h.Body)
                        .NotEmpty()
                        .MaximumLength(1000)
                ;

            RuleFor(h => h.IsRead)
                ;

            RuleFor(h => h.Note)
                        .MaximumLength(1000)
                ;


            RuleFor(h => h.Map)
                        .MaximumLength(1000)
                ;

        }
    }

    public class ContactCreateValidator : ContactBaseValidator<ContactCreateViewModel>
    {
        public ContactCreateValidator()
        {
        }
    }

    public class ContactEditValidator : ContactBaseValidator<ContactEditViewModel>
    {
        public ContactEditValidator()
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