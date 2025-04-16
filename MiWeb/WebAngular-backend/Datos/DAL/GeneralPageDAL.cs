using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class GeneralPageDAL
    {
        public static GeneralPageVMR GetOne(long id)
        {
            GeneralPageVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<GeneralPage>().Where(x => x.id == id).Select(x => new GeneralPageVMR
                {
                    id = x.id,
                    title = x.title
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
