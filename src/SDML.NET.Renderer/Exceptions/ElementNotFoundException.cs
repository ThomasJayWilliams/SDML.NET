using System;

namespace SDML.NET.Renderer
{
	public class ElementNotFoundException : Exception
	{
		private const string defaultMessage = "Element is not found!";

		public ElementNotFoundException() : base(defaultMessage) { }
		public ElementNotFoundException(string message) : base(message) { }
	}
}