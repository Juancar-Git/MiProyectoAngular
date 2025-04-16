using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class AboutDAL
    {
        public static AboutVMR GetOne(long id)
        {
            AboutVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<About>().Where(x => x.id == id).Select(x => new AboutVMR
                {
                    id = x.id,
                    sectionName = x.sectionName,
                    title = x.title,
                    mainSubtitle = x.mainSubtitle,
                    secondarySubtitle = x.secondarySubtitle,
                    description = x.description,
                    mainImagePath = x.mainImagePath,
                    generalPageId = x.generalPageId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
