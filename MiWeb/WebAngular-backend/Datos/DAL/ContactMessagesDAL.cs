using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Datos.DAL
{
    public class ContactMessagesDAL
    {
        
        public static PaginatedList<ContactMessagesVMR> GetAll(int quantity, int page, string searchText) 
        {
            PaginatedList<ContactMessagesVMR> result = new PaginatedList<ContactMessagesVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<ContactMessages>().Select(x => new ContactMessagesVMR
                {
                    id = x.id,
                    name = x.name ,
                    email = x.email ,
                    subject = x.subject
                });

                if (!string.IsNullOrEmpty(searchText))
                {
                    query = query.Where(x => x.name.Contains(searchText) || x.email.Contains(searchText) || x.subject.Contains(searchText));
                }

                result.totalQuantity = query.Count();

                result.elemento = query
                    .OrderBy(x => x.id)
                    .Skip(page * quantity)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }
        
        public static ContactMessagesVMR GetOne(long id) {
            ContactMessagesVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<ContactMessages>().Where(x => x.id == id).Select(x => new ContactMessagesVMR
                {
                    id = x.id,
                    name = x.name,
                    email = x.email,
                    subject = x.subject,
                    messageText = x.messageText,
                    contactId = x.contactId,
                }).FirstOrDefault();
            }

            return item;
        }
        
        public static long GetCreate(ContactMessages item) {

            using (var db = DbConexion.Create())
            {
                db.Set<ContactMessages>().Add(item);
                db.SaveChanges();
            }

            return 0;
        }
        public static void GetUpdate(ContactMessagesVMR item) {

            using (var db = DbConexion.Create())
            {
                var itemUpdate = db.Set<ContactMessages>().Find(item.id);

                itemUpdate.name = item.name;
                itemUpdate.email = item.email;
                itemUpdate.subject = item.subject;
                itemUpdate.messageText = item.messageText;
                itemUpdate.contactId = item.contactId;

                db.Entry(itemUpdate).State = System.Data.Entity.EntityState.Modified; 
                db.SaveChanges();
            }

        }
        public static void GetDelate(List<long> ids) {

            using (var db = DbConexion.Create())
            {
                var items = db.Set<ContactMessages>().Where(x => ids.Contains(x.id));

                foreach (var item in items)
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                }
                db.SaveChanges();
            }
        }
    }
}
