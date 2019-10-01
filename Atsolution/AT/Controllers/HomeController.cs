using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AT.Models;
using AT.Efs.Entities;

namespace AT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            HomeViewModel model = new HomeViewModel();
            model.listdocgia = _webcontext.AboutCustomer.ToList();
            model.listProj = _webcontext.Project.ToList();
            
            model.listBlog = _webcontext.News
                .OrderByDescending(p => p.CreatedDate)
                .ToList();

            return View(model);
        }
    }
}
