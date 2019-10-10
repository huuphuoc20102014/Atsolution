using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;


//// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AT.Controllers
{
    public class RecruitmentController : Controller
    {
        [HttpGet("tuyen-dung")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            RecruitementViewModel model = new RecruitementViewModel();
            model.Recruitement = _webcontext.News
                 .OrderByDescending(p => p.CreatedDate)
                 .ToList();
            return View(model);
        }
    }
}
