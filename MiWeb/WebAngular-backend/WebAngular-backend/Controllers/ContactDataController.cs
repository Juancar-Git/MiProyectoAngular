using Comun.ViewModel;
using Logica.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAngular_backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContactDataController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetOne(long id)
        {
            var response = new ResponseVMR<ContactDataVMR>();

            try
            {
                response.data = ContactDataBLL.GetOne(id);
            }
            catch (Exception ex)
            {
                response.code = HttpStatusCode.InternalServerError;
                response.data = null;
                response.messages.Add(ex.Message);
                response.messages.Add(ex.ToString());
            }

            if (response.data == null && response.messages.Count() == 0)
            {
                response.code = HttpStatusCode.NotFound;
                response.messages.Add("Elemento no encontrado");
            }

            return Content(response.code, response);
        }
    }
}
