namespace SDML.NET.Core.Attributes
{
	public class SdmlExtendsBaseAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "ExtendsBase";

		public SdmlExtendsBaseAttribute(string value) : base(value) { }
	}
}
