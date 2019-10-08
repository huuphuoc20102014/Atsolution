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
        public static async Task<RecruitementViewModel> GetDataRecruitement (WebAtSolutionContext webContext)
        {
            RecruitementViewModel model = new RecruitementViewModel();
            model.Recruitement = await webContext.News.ToListAsync();
            return model;
        }

       
    }
}
