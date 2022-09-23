using System;
using System.Runtime.Serialization;

namespace ExceptionHATA
{
    [Serializable]
    internal class dividebyzeroexception : Exception
    {
        public dividebyzeroexception()
        {
        }

        public dividebyzeroexception(string message) : base(message)
        {
        }

        public dividebyzeroexception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected dividebyzeroexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}