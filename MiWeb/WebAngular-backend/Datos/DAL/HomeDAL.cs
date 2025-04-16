using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class HomeDAL
    {
        public static HomeVMR GetOne(long id)
        {
            HomeVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<Home>().Where(x => x.id == id).Select(x => new HomeVMR
                {
                    id = x.id,
                    sectionName = x.sectionName,
                    title = x.title,
                    subtitle = x.subtitle,
                    backgroundImagePath = x.backgroundImagePath,
                    startButton = x.startButton,
                    videoButton = x.videoButton,
                    videoButtonUrl = x.videoButtonUrl,
                    generalPageId = x.generalPageId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}
