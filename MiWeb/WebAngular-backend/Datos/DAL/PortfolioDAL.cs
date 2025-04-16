using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class PortfolioDAL
    {
        public static PortfolioVMR GetOne(long id)
        {
            PortfolioVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<Portfolio>().Where(x => x.id == id).Select(x => new PortfolioVMR
                {
                    id = x.id,
                    sectionName = x.sectionName,
                    title = x.title,
                    generalPageId = x.generalPageId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
