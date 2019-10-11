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
        public IActionResult Index(string id, string type)
        {
            WebAtSolutionContext _webcontext = new WebAtSolutionContext();
            HomeViewModel model = new HomeViewModel();
            model.BlogT = _webcontext.NewsType.SingleOrDefault(p => p.Id == type);
            model.Blog = _webcontext.News.SingleOrDefault(p => p.Id == id);
            model.listBlog = _webcontext.News.ToList();
            model.listBlogT = _webcontext.NewsType.ToList();
            return View(model);
        }
    }
}
