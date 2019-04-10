namespace SDML.NET.Core.Attributes
{
	public class SdmlIsStaticAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsStatic";

		public SdmlIsStaticAttribute(string value) : base(value) { }
	}
}
