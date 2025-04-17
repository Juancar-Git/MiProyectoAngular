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
    public class AboutItemsBLL
    {
        public static List<AboutItemsVMR> GetAll(int quantity)
        {
            return AboutItemsDAL.GetAll(quantity);
        }
        public static AboutItemsVMR GetOne(long id)
        {
            return AboutItemsDAL.GetOne(id);
        }
    }
}
