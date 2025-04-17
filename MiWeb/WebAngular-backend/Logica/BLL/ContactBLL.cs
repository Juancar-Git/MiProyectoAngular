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
    public class ContactBLL
    {
        public static ContactVMR GetOne(long id)
        {
            return ContactDAL.GetOne(id);
        }
    }
}
