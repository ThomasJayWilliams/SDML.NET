namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlWritingAccessAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "WritingAccess";

		public SdmlWritingAccessAttribute(string value) : base(value) { }
	}
}
