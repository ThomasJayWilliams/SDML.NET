namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlExtendsBaseAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ExtendsBase";

		public SdmlExtendsBaseAttribute(string value) : base(value) { }
	}
}
