namespace SDML.NET.Core.Attributes
{
	public class SdmlIDAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "ID";

		public SdmlIDAttribute(string value) : base(value) { }
	}
}
