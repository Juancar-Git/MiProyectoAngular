using Comun.ViewModel;
using Datos.DAL;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BLL
{
    public class ContactMessagesBLL
    {
        public static PaginatedList<ContactMessagesVMR> GetAll(int quantity, int page, string searchText)
        {
            return ContactMessagesDAL.GetAll(quantity, page, searchText);
        }
        public static ContactMessagesVMR GetOne(long id)
        {
            return ContactMessagesDAL.GetOne(id);
        }

        public static long Create(ContactMessages item)
        {
            return ContactMessagesDAL.Create(item);
        }
        public static void Update(long id, ContactMessagesVMR item)
        {
            ContactMessagesDAL.Update(id, item);
        }
        public static void Delete(List<long> ids)
        {
            ContactMessagesDAL.Delete(ids);
        }
    }
}
