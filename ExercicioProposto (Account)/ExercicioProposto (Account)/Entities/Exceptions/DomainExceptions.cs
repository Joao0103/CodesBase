using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto__Account_.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
