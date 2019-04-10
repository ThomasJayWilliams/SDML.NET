namespace SDML.NET.Core.Attributes
{
	public class SdmlWritingAccessAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "WritingAccess";

		public SdmlWritingAccessAttribute(string value) : base(value) { }
	}
}
