using Comun.ViewModel;
using Datos.DAL;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BLL
{
    public class PortfolioItemsBLL
    {
        public static List<PortfolioItemsVMR> GetAll(int quantity)
        {
            return PortfolioItemsDAL.GetAll(quantity);
        }
        public static PortfolioItemsVMR GetOne(long id)
        {
            return PortfolioItemsDAL.GetOne(id);
        }
    }
}
