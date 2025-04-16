using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class ServicesEmployeesVMR
    {
        public long id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string job { get; set; }
        public string description { get; set; }
        public int stars { get; set; }
        public string pictureUrl { get; set; }
        public long servicesId { get; set; }
    }
}
