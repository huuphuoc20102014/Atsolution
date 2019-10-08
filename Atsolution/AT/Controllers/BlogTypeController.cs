using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Helpers;
using AT.Models;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class BlogTypeController : Controller
    {
        [HttpGet("chi-tiet-tin-tuc")]
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