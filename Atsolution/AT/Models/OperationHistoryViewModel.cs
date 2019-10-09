using AT.Efs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.Models
{
    public class OperationHistoryViewModel
    {
        public List<OperationHistory> listOperation { get; set; }
        public List<People> listPeople { get; set; }
        public AboutUs about { get; set; }
    }
}
