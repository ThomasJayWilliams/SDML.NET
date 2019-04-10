namespace SDML.NET.Core.Attributes
{
	public class SdmlIsContravariantAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsContravariant";

		public SdmlIsContravariantAttribute(string value) : base(value) { }
	}
}
