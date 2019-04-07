namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLExtendsBaseAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ExtendsBase";

		public SDMLExtendsBaseAttribute(string value) : base(value) { }
	}
}
