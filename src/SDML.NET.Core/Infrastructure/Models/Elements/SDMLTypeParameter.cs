using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
	public class SdmlTypeParameter : SdmlBaseElement
	{
		public override string ObjectName { get; } = "TypeParameter";

		public SdmlTypeParameter() : base() { }
		public SdmlTypeParameter(string value) : base(value) { }
		public SdmlTypeParameter(string value, params ISDMLObject[] elements) : base(value, elements) { }
		public SdmlTypeParameter(params ISDMLObject[] elements) : base(elements) { }
	}
}
