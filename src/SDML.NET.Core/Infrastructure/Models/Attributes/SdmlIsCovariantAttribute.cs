namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlIsCovariantAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsCovariant";

		public SdmlIsCovariantAttribute(string value) : base(value) { }
	}
}
