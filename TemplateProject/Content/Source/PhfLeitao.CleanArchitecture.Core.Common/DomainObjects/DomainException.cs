using System;

namespace PhfLeitao.CleanArchitecture.Core.Common.DomainObjects
{
    public class DomainException : Exception
    {
        public DomainException()
        { }

        public DomainException(string message) : base(message)
        { }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
