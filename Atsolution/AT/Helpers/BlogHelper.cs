using AT.Efs.Entities;
using AT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Helpers
{
    public class BlogHelper
    {
        public static async Task<HomeViewModel> GetDataBlog (WebAtSolutionContext webContext)
        {
            HomeViewModel model = new HomeViewModel();
            model.listBlog = webContext.News.ToList();
            model.listBlogT = webContext.NewsType.ToList();
            return model;
        }

        //public static async Task<List<Menu>> GetDataMenu(WebAtSolutionContext webContext)
        //{
        //    return await webContext.Menu.ToListAsync();
        //}
    }
}
