using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_20__Exception.Entities.Excepitions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
        
    }
}