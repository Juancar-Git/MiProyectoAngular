using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class ContactDAL
    {
        public static ContactVMR GetOne(long id)
        {
            ContactVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<Contact>().Where(x => x.id == id).Select(x => new ContactVMR
                {
                    id = x.id,
                    sectionName = x.sectionName,
                    title = x.title,
                    videoButton = x.videoButton,
                    generalPageId = x.generalPageId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}

