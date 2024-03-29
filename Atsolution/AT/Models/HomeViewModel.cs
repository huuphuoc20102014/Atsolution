using AT.Efs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Models
{
    public class HomeViewModel
    {
        public List<Project> listProj { get; set; }
        public List<News> listBlog { get; set; }
        public List<NewsType> listBlogT { get; set; }
        public News Blog { get; set; }
        public NewsType BlogT { get; set; }
        public List<ProjectImage> imageProject{ get; set; }
        public List<Service> listservice { get; set; }
        public List<Setting>listSetting { get; set; }
        public List<ImageSlide> listimg { get; set; }
        public List<SettingType> listsetingtitle { get; set; }
    }
}
