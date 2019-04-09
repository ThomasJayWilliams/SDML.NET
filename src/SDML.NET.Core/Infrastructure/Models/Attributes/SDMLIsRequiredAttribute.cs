namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlIsRequiredAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsRequired";

		public SdmlIsRequiredAttribute(string value) : base(value) { }
	}
}
