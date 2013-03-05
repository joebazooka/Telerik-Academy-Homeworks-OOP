using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class InvalidRangeException<T> : ApplicationException
    {
        // Constructors
        public InvalidRangeException() { }

        public InvalidRangeException(string message)
            : base(message) { }

        public InvalidRangeException(string message, System.Exception innerException)
            : base(message, innerException) { }
    }
}
