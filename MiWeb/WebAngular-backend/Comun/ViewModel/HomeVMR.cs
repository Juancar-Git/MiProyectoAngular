using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class HomeVMR
    {
        public long id { get; set; }
        public string sectionName { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string backgroundImagePath { get; set; }
        public string startButton { get; set; }
        public string videoButton { get; set; }
        public bool videoButtonUrl { get; set; }
        public long generalPageId { get; set; }
    }
}
