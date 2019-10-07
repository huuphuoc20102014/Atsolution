using AT.Efs.Entities;
using AT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Helpers
{
    public class ProjectsHelper
    {
        public static async Task<ProjectsViewModel> GetDataProjects(WebAtSolutionContext webContext)
        {
            ProjectsViewModel model = new ProjectsViewModel();         
            model.listProj = webContext.Project.ToList();
            model.listProjType = webContext.ProjectType.ToList();
            model.listProjImage = webContext.ProjectImage.ToList();
            return model;
        }

        //public static async Task<List<Menu>> GetDataMenu(WebAtSolutionContext webContext)
        //{
        //    return await webContext.Menu.ToListAsync();
        //}
    }
}
