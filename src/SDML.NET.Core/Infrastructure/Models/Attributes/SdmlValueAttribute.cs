namespace SDML.NET.Core.Attributes
{
	public class SdmlValueAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "Value";

		public SdmlValueAttribute(string value) : base(value) { }
	}
}
