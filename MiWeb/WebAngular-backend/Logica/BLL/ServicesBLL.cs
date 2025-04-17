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
    public class ServicesBLL
    {
        public static ServicesVMR GetOne(long id)
        {
            return ServicesDAL.GetOne(id);
        }
    }
}
