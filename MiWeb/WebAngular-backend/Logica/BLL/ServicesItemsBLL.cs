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
        public static List<ServicesItemsVMR> GetAll()
        {
            return ServicesItemsDAL.GetAll();
        }
        public static ServicesItemsVMR GetOne(long id)
        {
            return ServicesItemsDAL.GetOne(id);
        }
    }
}
