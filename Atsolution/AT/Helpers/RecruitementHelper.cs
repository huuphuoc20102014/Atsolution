using AT.Efs.Entities;
using AT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Helpers
{
    public class RecruitementHelper
    {
        public static async Task<HomeViewModel> GetDataRecruitement(WebAtSolutionContext webContext)
        {
            HomeViewModel model = new HomeViewModel();
            model.listBlog = webContext.News
                 .OrderByDescending(p => p.CreatedDate)
                 .ToList();
            model.listBlogT = webContext.NewsType.ToList();

            return model;
        }

    }
}
