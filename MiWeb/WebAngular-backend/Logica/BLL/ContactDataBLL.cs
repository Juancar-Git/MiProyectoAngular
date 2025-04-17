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
    public class ContactDataBLL
    {
        public static ContactDataVMR GetOne(long id)
        {
            return ContactDataDAL.GetOne(id);
        }
    }
}
