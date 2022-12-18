using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Response
{
    public class ResponseBase<T> where T : class
    {
        public T Response { get; set; }
        public string Message { get; set; }
        public HttpStatusCode Code { get; set; } = HttpStatusCode.OK;
        public bool Sucess { get; set; } = true;
    }

    public class ResponseBase
    {
        public string Message { get; set; }
        public HttpStatusCode Code { get; set; } = HttpStatusCode.OK;
        public bool Sucess { get; set; } = true;
    }
}
