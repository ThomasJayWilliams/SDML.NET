using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
	public class SdmlAttribute : SdmlBaseElement
	{
		public override string ObjectName { get; } = "Attribute";

		public SdmlAttribute() : base() { }
		public SdmlAttribute(string value) : base(value) { }
		public SdmlAttribute(string value, params ISdmlObject[] elements) : base(value, elements) { }
		public SdmlAttribute(params ISdmlObject[] elements) : base(elements) { }
	}
}
