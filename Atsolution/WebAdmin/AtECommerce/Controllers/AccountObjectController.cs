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
    public class AccountObjectController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;
        public AccountObjectController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }
        public async Task<IActionResult> Index([FromRoute]string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AccountObject dbItem = null;
                if (!string.IsNullOrWhiteSpace(id))
                {
                    dbItem = await _webcontext.AccountObject.AsNoTracking().FirstOrDefaultAsync(h => h.AccountObjectId == id);
                    if (dbItem == null)
                    {
                        return NotFound();
                    }
                }
                ViewData["ParentItem"] = dbItem;

                ViewData["ControllerNameForGrid"] = nameof(AccountObjectController).Replace("Controller", "");
                return View();
            }
            else
            {
                return RedirectToAction(nameof(ErrorController.Index), nameof(ErrorController).Replace("Controller", ""));
            }
        }
        public async Task<IActionResult> Index_Read([DataSourceRequest] DataSourceRequest request, string parentId)
        {
            var baseQuery = _webcontext.AccountObject.AsNoTracking()
                .Where(p => p.RowStatus == (int)AtRowStatus.Normal);
            if (!string.IsNullOrWhiteSpace(parentId))
            {
                baseQuery = baseQuery.Where(h => h.AccountObjectId == parentId);
            }
            var query = baseQuery
                .Select(h => new AccountObjectDetailsViewModel
                {
                    Id = h.AccountObjectId,
                    UserLogin = h.UserLogin,
                    AccountObjectCode = h.AccountObjectCode,
                    AccountObjectName = h.AccountObjectName,
                    BirthDate = h.BirthDate,
                    BirthPlace = h.BirthPlace,
                    Address = h.Address,
                    Mobile = h.Mobile,
                    EmailAddress = h.EmailAddress,
                    Country = h.Country,
                    ProvinceOrCity = h.ProvinceOrCity,
                    District = h.District,
                    WardOrCommune = h.WardOrCommune,
                    FkAccountObjectType = h.FkAccountObjectType,
                    CreatedBy = h.CreatedBy,
                    CreatedDate = h.CreatedDate,
                    ModifiedBy = h.ModifiedBy,
                    ModifiedDate = h.ModifiedDate,
                    RowVersion = h.RowVersion,
                    RowStatus = (AtRowStatus)h.RowStatus,
                    ImageSlug = h.ImageSlug
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

                var AccountObject = await _webcontext.AccountObject.AsNoTracking()
                        .Where(h => h.AccountObjectId == id)
                    .FirstOrDefaultAsync();
                if (AccountObject == null)
                {
                    return NotFound();
                }

                return View(AccountObject);
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
                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAccountObjectController).Replace("Controller", "");
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
        public async Task<IActionResult> Create([FromForm] AccountObjectCreateViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAccountObjectController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(AccountObject);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(p => p.Id == tableName);
            // Trim white space
            vmItem.AccountObjectCode = $"{vmItem.AccountObjectCode}".Trim();
            vmItem.AccountObjectName = $"{vmItem.AccountObjectName}".Trim();

            // Check code is existed
            if (await _webcontext.AccountObject.AnyAsync(h => h.AccountObjectCode == vmItem.AccountObjectCode))
            {
                ModelState.AddModelError(nameof(AccountObject.AccountObjectCode), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check username is existed
            if (await _webcontext.AccountObject.AnyAsync(h => h.UserLogin == vmItem.UserLogin))
            {
                ModelState.AddModelError(nameof(AccountObject.UserLogin), "The username has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Create save db item
            var dbItem = new AccountObject
            {
                AccountObjectId = Guid.NewGuid().ToString(),

                CreatedBy = _loginUserId,
                CreatedDate = DateTime.Now,
                ModifiedBy = null,
                ModifiedDate = null,
                RowStatus = (int)AtRowStatus.Normal,
                RowVersion = null,

                AccountObjectCode = vmItem.AccountObjectCode,
                AccountObjectName = vmItem.AccountObjectName,
                Gender = vmItem.Gender,
                BirthDate = vmItem.BirthDate,
                BirthPlace = vmItem.BirthPlace,
                Address = vmItem.Address,
                Mobile = vmItem.Mobile,
                Fax = vmItem.Fax,
                EmailAddress = vmItem.EmailAddress,
                Country = vmItem.Country,
                ProvinceOrCity = vmItem.ProvinceOrCity,
                District = vmItem.District,
                WardOrCommune = vmItem.WardOrCommune,
                FkAccountObjectType = vmItem.FkAccountObjectType,
                UserLogin = vmItem.UserLogin,
                PasswordLogin = vmItem.PasswordLogin,
                IsVendorLc = vmItem.IsVendorLc,
                IsVendorOf = vmItem.IsVendorOf,
                IsVendorCustoms = vmItem.IsVendorCustoms,
                IsVendorTrucking = vmItem.IsVendorTrucking,
                IsVendorProduct = vmItem.IsVendorProduct,
                ImageSlug = vmItem.ImageSlug
            };
            _webcontext.Add(dbItem);
            // Set time stamp for table to handle concurrency conflict     
            if (tableVersion != null)
            {
                tableVersion.LastModify = DateTime.Now;
            }
            await _webcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = dbItem.AccountObjectId });
        }
        public async Task<IActionResult> Edit([FromRoute] string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return NotFound();
                }

                ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAccountObjectController).Replace("Controller", "");

                var dbItem = await _webcontext.AccountObject.AsNoTracking()
                        .Where(h => h.AccountObjectId == id)
                        .Select(h => new AccountObjectEditViewModel
                        {
                            Id = h.AccountObjectId,
                            AccountObjectCode = h.AccountObjectCode,
                            AccountObjectName = h.AccountObjectName,
                            Gender = h.Gender,
                            BirthDate = h.BirthDate,
                            BirthPlace = h.BirthPlace,
                            Address = h.Address,
                            Mobile = h.Mobile,
                            Fax = h.Fax,
                            EmailAddress = h.EmailAddress,
                            Country = h.Country,
                            ProvinceOrCity = h.ProvinceOrCity,
                            District = h.District,
                            WardOrCommune = h.WardOrCommune,
                            FkAccountObjectType = h.FkAccountObjectType,
                            IsVendorLc = h.IsVendorLc,
                            IsVendorOf = h.IsVendorOf,
                            IsVendorCustoms = h.IsVendorCustoms,
                            IsVendorTrucking = h.IsVendorTrucking,
                            IsVendorProduct = h.IsVendorProduct,
                            ImageSlug = h.ImageSlug,
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
        public async Task<IActionResult> Edit([FromForm] AccountObjectEditViewModel vmItem)
        {
            ViewData["ControllerNameForImageBrowser"] = nameof(ImageBrowserAccountObjectController).Replace("Controller", "");

            // Invalid model
            if (!ModelState.IsValid)
            {
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Get time stamp for table to handle concurrency conflict
            var tableName = nameof(AccountObject);
            var tableVersion = await _webcontext.TableVersion.FirstOrDefaultAsync(h => h.Id == tableName);

            var dbItem = await _webcontext.AccountObject
                .Where(h => h.AccountObjectId == vmItem.Id)

                .FirstOrDefaultAsync();
            if (dbItem == null)
            {
                return NotFound();
            }

            // Trim white space
            vmItem.AccountObjectCode = $"{vmItem.AccountObjectCode}".Trim();
            vmItem.AccountObjectName = $"{vmItem.AccountObjectName}".Trim();

            // Check code is existed
            if (await _webcontext.AccountObject.AnyAsync(h => h.AccountObjectId != vmItem.Id && h.AccountObjectCode == vmItem.AccountObjectCode))
            {
                ModelState.AddModelError(nameof(AccountObject.AccountObjectCode), "The code has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Check username is existed
            if (await _webcontext.AccountObject.AnyAsync(h => h.AccountObjectId != vmItem.Id && h.UserLogin == vmItem.UserLogin))
            {
                ModelState.AddModelError(nameof(AccountObject.UserLogin), "The username has been existed.");
                // Get list master of foreign property and set to view data
                await PrepareListMasterForeignKey(vmItem);
                return View(vmItem);
            }

            // Update db item               
            dbItem.ModifiedBy = _loginUserId;
            dbItem.ModifiedDate = DateTime.Now;
            dbItem.RowVersion = vmItem.RowVersion;

            dbItem.AccountObjectCode = vmItem.AccountObjectCode;
            dbItem.AccountObjectName = vmItem.AccountObjectName;
            dbItem.Gender = vmItem.Gender;
            dbItem.BirthDate = vmItem.BirthDate;
            dbItem.BirthPlace = vmItem.BirthPlace;
            dbItem.Address = vmItem.Address;
            dbItem.Mobile = vmItem.Mobile;
            dbItem.Fax = vmItem.Fax;
            dbItem.EmailAddress = vmItem.EmailAddress;
            dbItem.Country = vmItem.Country;
            dbItem.ProvinceOrCity = vmItem.ProvinceOrCity;
            dbItem.District = vmItem.District;
            dbItem.WardOrCommune = vmItem.WardOrCommune;
            dbItem.FkAccountObjectType = vmItem.FkAccountObjectType;
            dbItem.IsVendorLc = vmItem.IsVendorLc;
            dbItem.IsVendorOf = vmItem.IsVendorOf;
            dbItem.IsVendorCustoms = vmItem.IsVendorCustoms;
            dbItem.IsVendorTrucking = vmItem.IsVendorTrucking;
            dbItem.IsVendorProduct = vmItem.IsVendorProduct;
            dbItem.ImageSlug = vmItem.ImageSlug;

            _webcontext.Entry(dbItem).Property(nameof(AccountObject.RowVersion)).OriginalValue = vmItem.RowVersion;

            await _webcontext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = dbItem.AccountObjectId });
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

                var dbItem = await _webcontext.AccountObject.AsNoTracking()
                        .Where(h => h.AccountObjectId == id)
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

            var dbItem = await _webcontext.AccountObject
                .Where(h => h.AccountObjectId == id)
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
                dbItem.ModifiedBy = _loginUserId;
                dbItem.ModifiedDate = DateTime.Now;
                dbItem.RowVersion = rowVersion;

                _webcontext.Entry(dbItem).Property(nameof(AccountObject.RowVersion)).OriginalValue = rowVersion;
                await _webcontext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }

        private async Task PrepareListMasterForeignKey(AccountObjectBaseViewModel vm = null)
        {
            ViewData["FkAccountObjectType"] = new SelectList(
                await _webcontext.AccountObjectType.AsNoTracking()
                    .Select(h => new { h.Id, h.AccountObjectTypeName })
                    .OrderBy(h => h.AccountObjectTypeName)
                    .ToListAsync(),
                "Id", "Name", vm?.FkAccountObjectType);
        }
    }
    public class ImageBrowserAccountObjectController : EditorImageBrowserController
    {
        public const string FOLDER_NAME = "ImagesAccountObject";
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

        public ImageBrowserAccountObjectController(IHostingEnvironment hostingEnvironment, IConfiguration staticFileSetting)
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
    public class AccountObjectBaseViewModel
    {
        public string AccountObjectCode { get; set; }
        public string AccountObjectName { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public decimal? AgreementSalary { get; set; }
        public decimal? SalaryCoefficient { get; set; }
        public int? NumberOfDependent { get; set; }
        public decimal? InsuranceSalary { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string Address { get; set; }
        public string AccountObjectGroupList { get; set; }
        public string AccountObjectGroupListCode { get; set; }
        public string CompanyTaxCode { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public string PaymentTermId { get; set; }
        public decimal? MaximizeDebtAmount { get; set; }
        public int? DueTime { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Country { get; set; }
        public string ProvinceOrCity { get; set; }
        public string District { get; set; }
        public string WardOrCommune { get; set; }
        public string Prefix { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactMobile { get; set; }
        public string OtherContactMobile { get; set; }
        public string ContactFixedTel { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        public int FkAccountObjectType { get; set; }
        public bool? Inactive { get; set; }
        public string OrganizationUnitId { get; set; }
        public string BranchId { get; set; }
        public decimal? ReceiptableDebtAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string AccountObjectGroupListName { get; set; }
        public string EmployeeId { get; set; }
        public string Description { get; set; }
        public string BankBranchName { get; set; }
        public string BankProvinceOrCity { get; set; }
        public string LegalRepresentative { get; set; }
        public string EinvoiceContactName { get; set; }
        public string EinvoiceContactEmail { get; set; }
        public string EinvoiceContactAddress { get; set; }
        public string EinvoiceContactMobile { get; set; }
        public string UserLogin { get; set; }
        public string PasswordLogin { get; set; }
        public bool IsVendorLc { get; set; }
        public bool IsVendorOf { get; set; }
        public bool IsVendorCustoms { get; set; }
        public bool IsVendorTrucking { get; set; }
        public bool IsVendorProduct { get; set; }
        public string FkAccountBusinessType { get; set; }
        public string ManageName { get; set; }
        public string ManagePhone { get; set; }
        public string ManageEmail { get; set; }
        public string ContactSkype { get; set; }
        public string DescriptionHtml { get; set; }
        public string ImageSlug { get; set; }
    }
    public class AccountObjectDetailsViewModel : AccountObjectBaseViewModel
    {
        public String Id { get; set; }
        public String CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public String ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Byte[] RowVersion { get; set; }
        public AtRowStatus RowStatus { get; set; }
    }
    public class AccountObjectCreateViewModel : AccountObjectBaseViewModel
    {

    }
    public class AccountObjectEditViewModel : AccountObjectBaseViewModel
    {
        public String Id { get; set; }
        public Byte[] RowVersion { get; set; }
    }
    public class AccountObjectBaseValidator<T> : AtBaseValidator<T> where T : AccountObjectBaseViewModel
    {
        public AccountObjectBaseValidator()
        {
            RuleFor(h => h.AccountObjectCode)
                        .NotEmpty()
                        .MaximumLength(25)
                ;

            RuleFor(h => h.AccountObjectName)
                        .NotEmpty()
                        .MaximumLength(128)
                ;

            RuleFor(h => h.Mobile)
                        .NotEmpty()
                        .MaximumLength(50)
                ;

            RuleFor(h => h.EmailAddress)
                        .NotEmpty()
                        .MaximumLength(100)
                ;
        }
    }
    public class AccountObjectCreateValidator : AccountObjectBaseValidator<AccountObjectCreateViewModel>
    {
        public AccountObjectCreateValidator()
        {
        }
    }
    public class AccountObjectEditValidator : AccountObjectBaseValidator<AccountObjectEditViewModel>
    {
        public AccountObjectEditValidator()
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