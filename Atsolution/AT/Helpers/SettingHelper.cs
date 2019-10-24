using AT.Efs.Entities;
using AT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Helpers
{
    public class SettingHelper
    {
        public static async Task<HomeViewModel> GetDataSetting (WebAtSolutionContext webContext)
        {
            HomeViewModel model = new HomeViewModel();
            model.listSetting =  webContext.Setting.ToList();
            model.listimg = webContext.ImageSlide.ToList();
            return model;
        }

        //public static async Task<List<Menu>> GetDataMenu(WebAtSolutionContext webContext)
        //{
        //    return await webContext.Menu.ToListAsync();
        //}
    }
}
