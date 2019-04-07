using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
	public class SDMLEvent : SDMLBaseElement
	{
		public override string ObjectName { get; } = "Event";

		public SDMLEvent() : base() { }
		public SDMLEvent(string value) : base(value) { }
		public SDMLEvent(string value, params ISDMLObject[] elements) : base(value, elements) { }
		public SDMLEvent(params ISDMLObject[] elements) : base(elements) { }
	}
}
