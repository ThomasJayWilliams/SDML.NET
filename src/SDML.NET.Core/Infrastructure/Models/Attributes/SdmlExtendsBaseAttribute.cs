namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlExtendsBaseAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "ExtendsBase";

		public SdmlExtendsBaseAttribute(string value) : base(value) { }
	}
}
