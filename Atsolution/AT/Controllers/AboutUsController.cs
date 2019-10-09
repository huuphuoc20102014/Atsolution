using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class AboutUsController : Controller
    {
        [HttpGet("gioi-thieu")]
        public IActionResult Index()
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            OperationHistoryViewModel model = new OperationHistoryViewModel();
            model.listOperation = _webcontext.OperationHistory.ToList();
            model.listPeople = _webcontext.People.ToList();
            model.about = _webcontext.AboutUs.Single();
            return View(model);
        }
    }
}