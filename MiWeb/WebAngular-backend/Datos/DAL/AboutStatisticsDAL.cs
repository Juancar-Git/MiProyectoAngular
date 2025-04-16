using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class AboutStatisticsDAL
    {
        public static List<AboutStatisticsVMR> GetAll(int quantity)
        {
            List<AboutStatisticsVMR> result = new List<AboutStatisticsVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<AboutStatistics>().Select(x => new AboutStatisticsVMR
                {
                    id = x.id,
                    name = x.name,
                    quantity = x.quantity,
                    icon = x.icon,
                    aboutId = x.aboutId
                });

                result = query
                    .OrderBy(x => x.id)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }

        public static AboutStatisticsVMR GetOne(long id)
        {
            AboutStatisticsVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<AboutStatistics>().Where(x => x.id == id).Select(x => new AboutStatisticsVMR
                {
                    id = x.id,
                    name = x.name,
                    quantity = x.quantity,
                    icon = x.icon,
                    aboutId = x.aboutId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
