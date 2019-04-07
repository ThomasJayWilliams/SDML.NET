using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
	public class SDMLTypeParameter : SDMLBaseElement
	{
		public override string ObjectName { get; } = "TypeParameter";

		public SDMLTypeParameter() : base() { }
		public SDMLTypeParameter(string value) : base(value) { }
		public SDMLTypeParameter(string value, params ISDMLObject[] elements) : base(value, elements) { }
		public SDMLTypeParameter(params ISDMLObject[] elements) : base(elements) { }
	}
}
