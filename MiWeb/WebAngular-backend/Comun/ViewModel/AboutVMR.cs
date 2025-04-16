using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class AboutVMR
    {
        public long id { get; set; }
        public string sectionName { get; set; }
        public string title { get; set; }
        public string mainSubtitle { get; set; }
        public string secondarySubtitle { get; set; }
        public string description { get; set; }
        public string mainImagePath { get; set; }
        public long generalPageId { get; set; }
    }
}
