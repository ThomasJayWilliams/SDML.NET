using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
	public class SDMLAttribute : SDMLBaseElement
	{
		public override string ObjectName { get; } = "Attribute";

		public SDMLAttribute() : base() { }
		public SDMLAttribute(string value) : base(value) { }
		public SDMLAttribute(string value, params ISDMLObject[] elements) : base(value, elements) { }
		public SDMLAttribute(params ISDMLObject[] elements) : base(elements) { }
	}
}
