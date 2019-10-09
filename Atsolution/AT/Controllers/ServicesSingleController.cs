using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AT.Models;
using AT.Efs.Entities;

namespace AT.Controllers
{
    public class ServicesSingleController : Controller
    {
        [HttpGet("chi-tiet-dich-vu")]
        public IActionResult Index(string id)
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            ServicesViewModel model = new ServicesViewModel();
            model.service = _webcontext.Service.SingleOrDefault(p => p.Id == id);
            model.listService = _webcontext.Service
                 .OrderByDescending(p => p.CreatedDate)
                 .ToList();
            return View(model);
        }
    }
}