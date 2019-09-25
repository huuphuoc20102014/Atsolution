using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtECommerce.Efs.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AtECommerce.Areas.Admin.Controllers
{
    public class BaseAdminController : Controller
    {
        protected WebAtSolutionContext WebAtSolutionContext { get; }

        public BaseAdminController(WebAtSolutionContext atSolutionContext)
        {
            WebAtSolutionContext = atSolutionContext;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            if (User.Identity.IsAuthenticated)
            {
                WebAtSolutionContext.LoginUserId = User.Identity.Name;
            }
            else
            {
                WebAtSolutionContext.LoginUserId = null;
            }
        }
    }
}