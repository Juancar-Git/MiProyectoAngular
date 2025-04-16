using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class ServicesItemsDAL
    {
        public static List<ServicesItemsVMR> GetAll(int quantity)
        {
            List<ServicesItemsVMR> result = new List<ServicesItemsVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<ServicesItems>().Select(x => new ServicesItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    icon = x.icon,
                    linkUrl = x.linkUrl,
                    servicesId = x.servicesId
                });

                result = query
                    .OrderBy(x => x.id)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }

        public static ServicesItemsVMR GetOne(long id)
        {
            ServicesItemsVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<ServicesItems>().Where(x => x.id == id).Select(x => new ServicesItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    icon = x.icon,
                    linkUrl = x.linkUrl,
                    servicesId = x.servicesId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
