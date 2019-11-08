using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AT.Controllers
{
    public class AboutUsController : Controller
    {
        [HttpGet("gioi-thieu")]
        public IActionResult Index()
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            OperationHistoryViewModel model = new OperationHistoryViewModel();
            model.listOperation = _webcontext.OperationHistory.OrderBy(p=>p.CreateDate).ToList();
            model.listPeople = _webcontext.People.ToList();
            model.about = _webcontext.AboutUs.Single();
            return View(model);
        }
     
    }
}