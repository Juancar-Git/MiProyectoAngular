using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class AboutSponsorsDAL
    {
        public static List<AboutSponsorsVMR> GetAll(int quantity)
        {
            List<AboutSponsorsVMR> result = new List<AboutSponsorsVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<AboutSponsors>().Select(x => new AboutSponsorsVMR
                {
                    id = x.id,
                    name = x.name,
                    imagePath = x.imagePath,
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

        public static AboutSponsorsVMR GetOne(long id)
        {
            AboutSponsorsVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<AboutSponsors>().Where(x => x.id == id).Select(x => new AboutSponsorsVMR
                {
                    id = x.id,
                    name = x.name,
                    imagePath = x.imagePath,
                    enabledItem = x.enabledItem,
                    aboutId = x.aboutId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}

