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
    public class ServicesItemsBLL
    {
        public static List<ServicesItemsVMR> GetAll(int quantity)
        {
            return ServicesItemsDAL.GetAll(quantity);
        }
        public static ServicesItemsVMR GetOne(long id)
        {
            return ServicesItemsDAL.GetOne(id);
        }
    }
}
