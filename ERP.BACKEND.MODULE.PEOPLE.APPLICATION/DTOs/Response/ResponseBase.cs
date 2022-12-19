namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Response
{
    using System.Net;

    public class ResponseBase<T> where T : class
    {
        public T Response { get; set; } = null!;
        public string Message { get; set; } = string.Empty;
        public HttpStatusCode Code { get; set; } = HttpStatusCode.OK;
        public bool Sucess { get; set; } = true;
    }

    public class ResponseBase
    {
        public string Message { get; set; } = string.Empty;
        public HttpStatusCode Code { get; set; } = HttpStatusCode.OK;
        public bool Sucess { get; set; } = true;
    }
}
