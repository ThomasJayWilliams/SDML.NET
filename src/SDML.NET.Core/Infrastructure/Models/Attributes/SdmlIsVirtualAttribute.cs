namespace SDML.NET.Core.Attributes
{
	public class SdmlIsVirtualAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsVirtual";

		public SdmlIsVirtualAttribute(string value) : base(value) { }
	}
}
