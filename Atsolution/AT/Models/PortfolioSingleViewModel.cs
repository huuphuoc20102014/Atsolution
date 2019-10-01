using AT.Efs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Models
{
    public class PortfolioSingleViewModel
    {
        public Project proj { get; set; }
        public List<Project> listproj { get; set; }
        public List<ProjectType> listprojType { get; set; }
    }
}
