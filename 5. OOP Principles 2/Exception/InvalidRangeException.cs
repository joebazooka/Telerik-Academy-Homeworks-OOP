using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; set; }
        public T End { get; set; }

        // Constructors
        public InvalidRangeException() { }

        public InvalidRangeException(string message, T start, T end)
            : base(message) 
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, System.Exception innerException, T start, T end)
            : base(message, innerException) 
        {
            this.Start = start;
            this.End = end;
        }
    }
}
