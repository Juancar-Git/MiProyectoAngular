using Comun.ViewModel;
using Datos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BLL
{
    public class HomeBLL
    {
        public static HomeVMR GetOne(long id)
        {
            return HomeDAL.GetOne(id);
        }
    }
}
