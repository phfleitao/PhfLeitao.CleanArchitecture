using System.Collections.Generic;

namespace PhfLeitao.CleanArchitecture.Core.Application.Wrappers
{
    public class Response<T>
    {
        public bool Succeeded { get; private set; }
        public string Message { get; private set; }
        public IEnumerable<string> Erros { get; private set; }
        public T Data { get; private set; }

        public Response(T data, bool succeeded, string message, IEnumerable<string> erros)
        {
            Data = data;
            Succeeded = succeeded;
            Message = message;
            Erros = erros;
        }

        public Response(T data, bool succeeded, string message)
        {
            Data = data;
            Succeeded = succeeded;
            Message = message;
            Erros = new List<string>();
        }

        public Response(T data, string message = null)
        {
            Data = data;
            Succeeded = true;
            Message = message;
            Erros = new List<string>();
        }

        public Response(bool succeeded, string message, IEnumerable<string> erros)
        {
            Succeeded = succeeded;
            Message = message;
            Erros = erros;
        }

        public Response(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Message = message;
            Erros = new List<string>();
        }

        public Response(string message)
        {
            Succeeded = false;
            Message = message;
            Erros = new List<string>();
        }
    }
}