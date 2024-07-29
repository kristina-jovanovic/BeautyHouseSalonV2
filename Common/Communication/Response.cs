using System;

namespace Common.Communication
{
    [Serializable]
    public class Response
    {
        public object Result { get; set; }
        public string Message { get; set; }
        public bool IsSuccessfull { get; set; }
        public Response()
        {

        }
        public Response(object result, string message, bool isSuccesfull)
        {
            Result = result;
            Message = message;
            IsSuccessfull = isSuccesfull;
        }
    }
}
