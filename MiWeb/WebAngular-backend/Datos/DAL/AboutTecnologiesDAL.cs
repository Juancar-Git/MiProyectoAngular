using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class AboutTecnologiesDAL
    {
        public static List<AboutTecnologiesVMR> GetAll(int quantity)
        {
            List<AboutTecnologiesVMR> result = new List<AboutTecnologiesVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<AboutTecnologies>().Select(x => new AboutTecnologiesVMR
                {
                    id = x.id,
                    name = x.name,
                    percentage = x.percentage,
                    aboutId = x.aboutId
                });

                result = query
                    .OrderBy(x => x.id)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }

        public static AboutTecnologiesVMR GetOne(long id)
        {
            AboutTecnologiesVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<AboutTecnologies>().Where(x => x.id == id).Select(x => new AboutTecnologiesVMR
                {
                    id = x.id,
                    name = x.name,
                    percentage = x.percentage,
                    aboutId = x.aboutId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
