namespace SDML.NET.Core.Attributes
{
	public class SdmlOverridesBaseAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "OverridesBase";

		public SdmlOverridesBaseAttribute(string value) : base(value) { }
	}
}
