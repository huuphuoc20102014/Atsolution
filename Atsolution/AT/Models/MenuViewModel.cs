using AT.Efs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Models
{
    public class MenuViewModel
    {
        public List<Menu> listMenu { get; set; }
        public List<Service> listService { get; set; }
        public List<Contact> listContact { get; set; }
        public List<AboutCustomer> listPartner { get; set; }
    }
}

