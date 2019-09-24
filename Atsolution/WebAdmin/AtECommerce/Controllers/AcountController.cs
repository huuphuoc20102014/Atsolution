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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using AtECommerce.Models;

namespace AtECommerce.Controllers
{
    public class AcountController : AtBaseController
    {
        private readonly WebGoldenSeaContext _webcontext;

        public AcountController(WebGoldenSeaContext webcontext)
        {
            _webcontext = webcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet("dang-nhap")]
        public IActionResult DangNhap([FromQuery] string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new AccountObjectViewModel
            {
                ReturnUrl = returnUrl
            });
        }
        [AllowAnonymous]
        [HttpPost("dang-nhap")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DangNhap([FromForm]AccountObjectViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            try
            {
                var dbUser = await _webcontext.AccountObject.AsNoTracking()
                        .FirstOrDefaultAsync(h => h.UserLogin == vm.UserLogin && h.PasswordLogin == vm.PasswordLogin && h.FkAccountObjectType == 4);
                if (dbUser == null)
                {
                    //ModelState.AddModelError("Fail", "Tên đăng nhập hoặc mật khẩu không đúng.");
                    TempData["UserLoginFailed"] = "Tên đăng nhập hoặc mật khẩu không đúng";
                    return View(vm);
                }

                var lastChange = dbUser.RowVersion.Select(h => h.ToString("X2")).Aggregate((a, b) => a + b);
                //Startup.LastChanged.AddOrUpdate(dbUser.AccountObjectId, lastChange, (key, oldValue) => lastChange);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dbUser.AccountObjectName),
                    new Claim("FullName", dbUser.AccountObjectName),
                    new Claim("FullCode", dbUser.AccountObjectCode),
                    //new Claim("StoreId", dbUser.FkStoreId),
                    //new Claim(ClaimTypes.Role, ((int)dbUser.Permission).ToString()),
                    //new Claim("LastChanged", dbUser.RowVersion.Select(h => h.ToString("X2")).Aggregate((a,b) =>  a + b))
                    new Claim("LastChanged", lastChange)
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                if (string.IsNullOrWhiteSpace(vm.ReturnUrl))
                {
                    return RedirectToAction(nameof(HomeController.Index),
                        nameof(HomeController).Replace("Controller", ""));
                }
                else
                {
                    return LocalRedirect(vm.ReturnUrl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return View(vm);
        }
        [HttpGet("dang-xuat")]
        public async Task<IActionResult> DangXuat()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(AcountController.DangNhap), nameof(AcountController).Replace("Controller", ""));
        }
        //dăng ký
        [AllowAnonymous]
        public IActionResult register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> register([FromForm]AccountObjectViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            AccountObject account = new AccountObject();
            try
            {
                account.AccountObjectId = Guid.NewGuid().ToString();
                account.AccountObjectCode = "AccountObjectCode";
                account.FkAccountObjectType = 1;
                account.UserLogin = vm.UserLogin;
                account.PasswordLogin = vm.PasswordLogin;
                account.EmailAddress = vm.EmailAddress;
                account.ContactEmail = vm.EmailAddress;
                account.IsVendorLc = false;
                account.IsVendorOf = false;
                account.IsVendorCustoms = false;
                account.IsVendorTrucking = false;
                account.IsVendorProduct = false;
                account.RowStatus = 0;

                _webcontext.AccountObject.Add(account);
                await _webcontext.SaveChangesAsync();

                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", ""));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}