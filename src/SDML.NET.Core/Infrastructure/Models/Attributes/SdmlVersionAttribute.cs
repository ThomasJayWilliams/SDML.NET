namespace SDML.NET.Core.Attributes
{
	public class SdmlVersionAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "Version";

		public SdmlVersionAttribute(string value) : base(value) { }
	}
}
