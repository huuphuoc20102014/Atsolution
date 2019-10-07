using AT.Efs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Models
{
    public class ProjectsViewModel
    {
        public List<Project> listProj { get; set; }
        public List<ProjectType> listProjType { get; set; }
        public List<ProjectImage> listProjImage { get; set; }
    }
}
