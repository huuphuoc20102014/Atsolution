using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class PortfolioSingleController : Controller
    {
        [HttpGet("chi-tiet-du-an")]
        public IActionResult Index(string id)
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            PortfolioSingleViewModel model = new PortfolioSingleViewModel();
            model.proj = _webcontext.Project.SingleOrDefault(u => u.Id == id);
            model.listproj = _webcontext.Project.ToList();
            model.listprojType = _webcontext.ProjectType.ToList();
            return View(model);
        }
    }
}