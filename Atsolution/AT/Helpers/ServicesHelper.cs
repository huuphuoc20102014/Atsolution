using AT.Efs.Entities;
using AT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Helpers
{
    public class ServicesHelper
    {
        public static async Task<ServicesViewModel> GetDataServices(WebAtSolutionContext webContext)
        {
            ServicesViewModel model = new ServicesViewModel();
            model.listService = webContext.Service.ToList();
            model.listProj = webContext.Project.ToList();
            model.listProjType = webContext.ProjectType.ToList();
            return model;
        }

        //public static async Task<List<Menu>> GetDataMenu(WebAtSolutionContext webContext)
        //{
        //    return await webContext.Menu.ToListAsync();
        //}
    }
}
