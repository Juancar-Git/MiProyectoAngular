using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class PortfolioItemsVMR
    {
        public long id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string pictureUrl { get; set; }
        public long portfolioId { get; set; }
    }
}
