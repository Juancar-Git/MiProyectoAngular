using Comun.ViewModel;
using Datos.DAL;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.BLL
{
    public class AboutSponsorsBLL
    {
        public static List<AboutSponsorsVMR> GetAll(int quantity)
        {
            return AboutSponsorsDAL.GetAll(quantity);
        }
        public static AboutSponsorsVMR GetOne(long id)
        {
            return AboutSponsorsDAL.GetOne(id);
        }
    }
}
