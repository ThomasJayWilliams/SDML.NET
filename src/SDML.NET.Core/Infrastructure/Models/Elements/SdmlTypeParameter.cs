namespace SDML.NET.Core.Elements
{
	public class SdmlTypeParameter : SdmlBaseElement
	{
		public override string ObjectName { get; } = "TypeParameter";

		public SdmlTypeParameter() : base() { }
		public SdmlTypeParameter(string value) : base(value) { }
		public SdmlTypeParameter(string value, params ISdmlObject[] elements) : base(value, elements) { }
		public SdmlTypeParameter(params ISdmlObject[] elements) : base(elements) { }
	}
}
