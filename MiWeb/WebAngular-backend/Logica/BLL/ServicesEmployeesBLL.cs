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
    public class ServicesEmployeesBLL
    {
        public static List<ServicesEmployeesVMR> GetAll(int quantity)
        {
            return ServicesEmployeesDAL.GetAll(quantity);
        }
        public static ServicesEmployeesVMR GetOne(long id)
        {
            return ServicesEmployeesDAL.GetOne(id);
        }
    }
}
