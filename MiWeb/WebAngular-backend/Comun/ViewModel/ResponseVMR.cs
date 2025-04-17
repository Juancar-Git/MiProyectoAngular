using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Comun.ViewModel
{
    public class ResponseVMR<T>
    {
        public HttpStatusCode code { get; set; }
        public T data { get; set; }
        public List<string> messages { get; set; }

        public ResponseVMR() 
        { 
            code = HttpStatusCode.OK;
            data = default(T);
            messages = new List<string>();
        }
    }
}
