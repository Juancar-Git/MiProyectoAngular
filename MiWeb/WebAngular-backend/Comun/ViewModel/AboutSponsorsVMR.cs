using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class AboutSponsorsVMR
    {
        public long id { get; set; }
        public string name { get; set; }
        public string imagePath { get; set; }
        public bool enabledItem { get; set; }
        public long aboutId { get; set; }
    }
}
