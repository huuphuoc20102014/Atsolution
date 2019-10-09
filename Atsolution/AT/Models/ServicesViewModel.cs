using AT.Efs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Models
{
    public class ServicesViewModel
    {
        public List<Service> listService { get; set; }
        public Service service  { get; set; }
        public List<Project> listProj { get; set; }
        public List<ProjectType> listProjType { get; set; }
    }
}
