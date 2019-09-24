using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtECommerce.Efs.Entities;
using GenEf.Efs.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AtECommerce.Areas.Admin.Controllers
{
    public class BaseAdminController : Controller
    {
        protected WebGoldenSeaContext AtECommerceContext { get; }

        public BaseAdminController(WebGoldenSeaContext atECommerceContext)
        {
            AtECommerceContext = atECommerceContext;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            if (User.Identity.IsAuthenticated)
            {
                AtECommerceContext.LoginUserId = User.Identity.Name;
            }
            else
            {
                AtECommerceContext.LoginUserId = null;
            }
        }
    }
}