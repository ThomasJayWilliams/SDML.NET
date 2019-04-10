namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlOverridesBaseAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "OverridesBase";

		public SdmlOverridesBaseAttribute(string value) : base(value) { }
	}
}
