using Comun.ViewModel;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAL
{
    public class PortfolioItemsDAL
    {
        public static List<PortfolioItemsVMR> GetAll(int quantity)
        {
            List<PortfolioItemsVMR> result = new List<PortfolioItemsVMR>();

            using (var db = DbConexion.Create())
            {
                var query = db.Set<PortfolioItems>().Select(x => new PortfolioItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    pictureUrl = x.pictureUrl,
                    portfolioId = x.portfolioId
                });

                result = query
                    .OrderBy(x => x.id)
                    .Take(quantity)
                    .ToList();
            }

            return result;
        }

        public static PortfolioItemsVMR GetOne(long id)
        {
            PortfolioItemsVMR item = null;

            using (var db = DbConexion.Create())
            {
                item = db.Set<PortfolioItems>().Where(x => x.id == id).Select(x => new PortfolioItemsVMR
                {
                    id = x.id,
                    title = x.title,
                    description = x.description,
                    pictureUrl = x.pictureUrl,
                    portfolioId = x.portfolioId
                }).FirstOrDefault();
            }

            return item;
        }
    }
}

