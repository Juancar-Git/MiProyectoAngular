using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class ServicesEmployeesDAL
    {
        public static List<ServicesEmployeesVMR> GetAll(int quantity)
        {
            List<ServicesEmployeesVMR> result = new List<ServicesEmployeesVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<ServicesEmployees>().Select(x => new ServicesEmployeesVMR
                {
                    id = x.id,
                    name = x.name,
                    lastName = x.lastName,
                    job = x.job,
                    description = x.description,
                    stars = x.stars,
                    pictureUrl = x.pictureUrl,
                    servicesId = x.servicesId
                });

                result = query
                    .OrderBy(x => x.id)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }

        public static ServicesEmployeesVMR GetOne(long id)
        {
            ServicesEmployeesVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<ServicesEmployees>().Where(x => x.id == id).Select(x => new ServicesEmployeesVMR
                {
                    id = x.id,
                    name = x.name,
                    lastName = x.lastName,
                    job = x.job,
                    description = x.description,
                    stars = x.stars,
                    pictureUrl = x.pictureUrl,
                    servicesId = x.servicesId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}