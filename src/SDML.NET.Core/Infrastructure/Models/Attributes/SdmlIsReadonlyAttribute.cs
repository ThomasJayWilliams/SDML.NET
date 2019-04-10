namespace SDML.NET.Core.Attributes
{
	public class SdmlIsReadonlyAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsReadonly";

		public SdmlIsReadonlyAttribute(string value) : base(value) { }
	}
}
