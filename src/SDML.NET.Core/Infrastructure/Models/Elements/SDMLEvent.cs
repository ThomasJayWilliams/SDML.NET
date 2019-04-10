using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
	public class SdmlEvent : SdmlBaseElement
	{
		public override string ObjectName { get; } = "Event";

		public SdmlEvent() : base() { }
		public SdmlEvent(string value) : base(value) { }
		public SdmlEvent(string value, params ISDMLObject[] elements) : base(value, elements) { }
		public SdmlEvent(params ISDMLObject[] elements) : base(elements) { }
	}
}
