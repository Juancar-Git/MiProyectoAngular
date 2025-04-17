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
    public class AboutTecnologiesBLL
    {
        public static List<AboutTecnologiesVMR> GetAll(int quantity)
        {
            return AboutTecnologiesDAL.GetAll(quantity);
        }
        public static AboutTecnologiesVMR GetOne(long id)
        {
            return AboutTecnologiesDAL.GetOne(id);
        }
    }
}
