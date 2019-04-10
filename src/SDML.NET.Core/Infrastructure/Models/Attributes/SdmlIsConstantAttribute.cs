namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlIsConstantAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsConstant";

		public SdmlIsConstantAttribute(string value) : base(value) { }
	}
}
