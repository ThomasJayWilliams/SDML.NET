namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlReadingAccessAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "ReadingAccess";

		public SdmlReadingAccessAttribute(string value) : base(value) { }
	}
}
