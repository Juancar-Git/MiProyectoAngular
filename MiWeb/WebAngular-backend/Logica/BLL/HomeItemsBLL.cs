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
    public class HomeItemsBLL
    {
        public static List<HomeItemsVMR> GetAll(int quantity)
        {
            return HomeItemsDAL.GetAll(quantity);
        }

        public static HomeItemsVMR GetOne(long id)
        {
            return HomeItemsDAL.GetOne(id);
        }

    }
}
