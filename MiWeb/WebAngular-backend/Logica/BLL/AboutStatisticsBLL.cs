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
    public class AboutStatisticsBLL
    {
        public static List<AboutStatisticsVMR> GetAll(int quantity)
        {
            return AboutStatisticsDAL.GetAll(quantity);
        }
        public static AboutStatisticsVMR GetOne(long id)
        {
            return AboutStatisticsDAL.GetOne(id);
        }
    }
}
