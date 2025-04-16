using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class HomeItemsVMR
    {
        public long id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public string linkUrl { get; set; }
        public bool enabledItem { get; set; }
        public long homeId { get; set; }
    }
}
