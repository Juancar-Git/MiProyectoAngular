using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class PaginatedList<T>
    {
        public int totalQuantity { get; set; }
        public IEnumerable<T> elemento { get; set; }

        public PaginatedList() { 
            elemento = new List<T>();
            totalQuantity = 0;
        }
    }
}
