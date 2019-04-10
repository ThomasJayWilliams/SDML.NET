namespace SDML.NET.Core.Attributes
{
	public class SdmlReturnTypeAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "ReturnType";

		public SdmlReturnTypeAttribute(string value) : base(value) { }
	}
}
