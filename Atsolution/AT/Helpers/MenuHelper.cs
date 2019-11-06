using AT.Efs.Entities;
using AT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Helpers
{
    public class MenuHelper
    {
        public static async Task<MenuViewModel> GetDataMenu(WebAtSolutionContext webContext)
        {
            MenuViewModel model = new MenuViewModel();
            model.listMenu = await webContext.Menu.ToListAsync();
            model.listService = await webContext.Service.ToListAsync();
            model.listContact = await webContext.Contact.Where(p=>p.Id == "CT001").ToListAsync();
            model.listPartner = await webContext.AboutCustomer.ToListAsync();
            model.listNewType = await webContext.NewsType.ToListAsync();
            return model;
        }

        //public static async Task<List<Menu>> GetDataMenu(WebAtSolutionContext webContext)
        //{
        //    return await webContext.Menu.ToListAsync();
        //}
    }
}
