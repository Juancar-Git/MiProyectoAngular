using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class AboutItemsDAL
    {

        public static List<AboutItemsVMR> GetAll(int quantity)
        {
            List<AboutItemsVMR> result = new List<AboutItemsVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<AboutItems>().Select(x => new AboutItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    icon = x.icon,
                    enabledItem = x.enabledItem,
                    aboutId = x.aboutId
                });

                result = query
                    .OrderBy(x => x.id)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }

        public static AboutItemsVMR GetOne(long id)
        {
            AboutItemsVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<AboutItems>().Where(x => x.id == id).Select(x => new AboutItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    icon = x.icon,
                    enabledItem = x.enabledItem,
                    aboutId = x.aboutId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
