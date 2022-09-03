using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Checkpoint.UI.Exceptions
{
    [Serializable]
    public class InvalidaException : Exception
    {
        public InvalidaException() { }
        public InvalidaException(string message) : base(message) { }
        public InvalidaException(string message, Exception inner) : base(message, inner) { }
        protected InvalidaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
