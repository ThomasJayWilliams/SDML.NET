using System;

namespace SDML.NET.Core
{
	// Appears, when input element is invalid
    public class InvalidElementDeclarationException : Exception
    {
        private static string _defaultMessage = "Element is not well formed!";

        public InvalidElementDeclarationException() : base(_defaultMessage) { }
        public InvalidElementDeclarationException(string message) : base(message) { }
    }
}
