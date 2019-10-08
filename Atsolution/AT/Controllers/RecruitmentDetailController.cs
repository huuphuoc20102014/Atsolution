using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AT.Controllers
{
    public class RecruitmentDetailController : Controller
    {
        [HttpGet("chi-tiet-tuyen-dung")]       
        public IActionResult Index( string id)
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            RecruitmentDetailViewModel model = new RecruitmentDetailViewModel();
            model.Recuit = _webcontext.News.SingleOrDefault(p => p.Id == id);
            model.listRecruitement = _webcontext.News.ToList();
            return View(model);
        }
    }
}
