using Comun.ViewModel;
using Datos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BLL
{
    public class AboutBLL
    {
        public static AboutVMR GetOne(long id)
        {
            return AboutDAL.GetOne(id);
        }
    }
}
