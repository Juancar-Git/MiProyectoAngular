using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class ContactDataDAL
    {
        public static ContactDataVMR GetOne(long id)
        {
            ContactDataVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<ContactData>().Where(x => x.id == id).Select(x => new ContactDataVMR
                {
                    id = x.id,
                    address = x.address,
                    phone = x.phone,
                    email = x.email,
                    mapIframeSrc = x.mapIframeSrc,
                    contactId = x.contactId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}

