namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlIsReadonlyAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsReadonly";

		public SdmlIsReadonlyAttribute(string value) : base(value) { }
	}
}
