using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class ServicesDAL
    {
        public static ServicesVMR GetOne(long id)
        {
            ServicesVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<Services>().Where(x => x.generalPageId == id).Select(x => new ServicesVMR
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