using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Layer.Exceptions
{
    // Cunstom exception for not found entity
    public class NotFoundException : Exception
    {
        public NotFoundException() { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception inner) : base(message, inner) { }

        public NotFoundException(string name, object key) : base($"Entity \"{name}\" ({key}) was not found ") { }
    }
}
