using System;

namespace SDML.NET.Core.Exceptions
{
    public class InvalidNodeException : Exception
    {
        public string InternalMessage { get; set; } = "Node is invalid!";

        public InvalidNodeException() : base() { }
        public InvalidNodeException(string message) : base(message)
        {
            InternalMessage = message;
        }
    }
}
