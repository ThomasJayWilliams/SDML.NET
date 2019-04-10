namespace SDML.NET.Core.Attributes
{
	public class SdmlIsConstantAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsConstant";

		public SdmlIsConstantAttribute(string value) : base(value) { }
	}
}
