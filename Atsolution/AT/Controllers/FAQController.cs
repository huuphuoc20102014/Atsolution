using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AT.Efs;
using AT.Efs.Entities;
using AT.Models;

namespace AT.Controllers
{
    public class FAQController : GsControllerBase<FAQController>
    {
        public FAQController(WebAtSolutionContext webContext) : base(webContext)
        {

        }
        public IActionResult Index()
        {
            FAQViewModel model = new FAQViewModel();
            model.faqList = _webContext.Faq.ToList();
            return View(model);
        }
    }
}