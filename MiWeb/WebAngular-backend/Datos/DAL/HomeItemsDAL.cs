using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class HomeItemsDAL
    {
        public static List<HomeItemsVMR> GetAll(int quantity)
        {
            List<HomeItemsVMR> result = new List<HomeItemsVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<HomeItems>().Select(x => new HomeItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    icon = x.icon,
                    linkUrl = x.linkUrl,
                    enabledItem = x.enabledItem,
                    homeId = x.homeId
                });

                result = query
                    .OrderBy(x => x.id)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }

        public static HomeItemsVMR GetOne(long id)
        {
            HomeItemsVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<HomeItems>().Where(x => x.id == id).Select(x => new HomeItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    icon = x.icon,
                    linkUrl = x.linkUrl,
                    enabledItem = x.enabledItem,
                    homeId = x.homeId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
