using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    [Serializable]
    class ExceedCapacityException : ApplicationException
    {
        public ExceedCapacityException() { }

        public ExceedCapacityException(string message) : base(message) { }

        public ExceedCapacityException(string message, System.Exception inner) : base(message,inner) { }

        protected ExceedCapacityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
