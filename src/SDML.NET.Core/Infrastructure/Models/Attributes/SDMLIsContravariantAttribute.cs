namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlIsContravariantAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsContravariant";

		public SdmlIsContravariantAttribute(string value) : base(value) { }
	}
}
