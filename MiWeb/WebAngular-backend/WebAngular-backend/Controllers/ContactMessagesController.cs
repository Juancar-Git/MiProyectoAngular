using Comun.ViewModel;
using Logica.BLL;
using Modelo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAngular_backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContactMessagesController : ApiController
    {
        /*
         *  url
            http://localhost:3059/api/contactmessages?quantity=1&page=1&searchText=
         */
        [HttpGet]
        public IHttpActionResult GetAll(int quantity = 10, int page = 0, string searchText = null)
        {
            var response = new ResponseVMR<PaginatedList<ContactMessagesVMR>>();

            try
            {
                response.data = ContactMessagesBLL.GetAll(quantity, page, searchText);
            }catch (Exception ex)
            {
                response.code = HttpStatusCode.InternalServerError;
                response.data = null;
                response.messages.Add(ex.Message);
                response.messages.Add(ex.ToString());
            }

            return Content(response.code, response);
        }
        /*
         *  url
                http://localhost:3059/api/contactmessages/1
         */
        [HttpGet]
        public IHttpActionResult GetOne(long id)
        {
            var response = new ResponseVMR<ContactMessagesVMR>();

            try
            {
                response.data = ContactMessagesBLL.GetOne(id);
            }
            catch (Exception ex)
            {
                response.code = HttpStatusCode.InternalServerError;
                response.data = null;
                response.messages.Add(ex.Message);
                response.messages.Add(ex.ToString());
            }

            if(response.data == null && response.messages.Count() == 0)
            {
                response.code = HttpStatusCode.NotFound;
                response.messages.Add("Elemento no encontrado");
            }

            return Content(response.code, response);
        }
        /*
         *  url
                http://localhost:3059/api/contactmessages
            body
                {
                    "name": "nombre ejemplo",
                    "email": "email@ejemplo.com",
                    "subject": "nombre ejemplo",
                    "messageText": "nombre ejemplo asdfasdfasdfas",
                    "contactId": 3
                }
         */
        [HttpPost]
        public IHttpActionResult Create(ContactMessages item)
        {
            var response = new ResponseVMR<long?>();

            try
            {
                response.data = ContactMessagesBLL.Create(item);
            }
            catch (Exception ex)
            {
                response.code = HttpStatusCode.InternalServerError;
                response.data = null;
                response.messages.Add(ex.Message);
                response.messages.Add(ex.ToString());
            }

            return Content(response.code, response);
        }


        /*
         *  url
                http://localhost:3059/api/contactmessages/1
            body
                {
                    "name": "nombre ejemplo",
                    "email": "email@ejemplo.com",
                    "subject": "nombre ejemplo",
                    "messageText": "nombre ejemplo asdfasdfasdfas",
                    "contactId": 3
                }
         */
        [HttpPut]
        public IHttpActionResult Update(long id, ContactMessagesVMR item)
        {
            var response = new ResponseVMR<bool?>();

            try
            {
                ContactMessagesBLL.Update(id, item);
                response.data = true;
            }
            catch (Exception ex)
            {
                response.code = HttpStatusCode.InternalServerError;
                response.data = false;
                response.messages.Add(ex.Message);
                response.messages.Add(ex.ToString());
            }

            return Content(response.code, response);
        }

        /*
         *  url
                http://localhost:3059/api/contactmessages
            body
                [1]
         */
        [HttpDelete]
        public  IHttpActionResult Delete(List<long> ids)
        {
            var response = new ResponseVMR<bool?>();

            try
            {
                ContactMessagesBLL.Delete(ids);
                response.data = true;
            }
            catch (Exception ex)
            {
                response.code = HttpStatusCode.InternalServerError;
                response.data = false;
                response.messages.Add(ex.Message);
                response.messages.Add(ex.ToString());
            }

            return Content(response.code, response);
        }
        
    }
}
