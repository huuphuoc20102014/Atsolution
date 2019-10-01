using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class ServicesController : Controller
    {
        [HttpGet("dich-vu")]
        public IActionResult Index()
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            ServicesViewModel model = new ServicesViewModel();
            model.listService = _webcontext.Service.ToList();
            model.listProj = _webcontext.Project.ToList();
            model.listProjType = _webcontext.ProjectType.ToList();
            return View(model);
        }
    }
}