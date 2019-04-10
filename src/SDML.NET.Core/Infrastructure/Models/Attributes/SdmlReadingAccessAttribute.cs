namespace SDML.NET.Core.Attributes
{
	public class SdmlReadingAccessAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "ReadingAccess";

		public SdmlReadingAccessAttribute(string value) : base(value) { }
	}
}
