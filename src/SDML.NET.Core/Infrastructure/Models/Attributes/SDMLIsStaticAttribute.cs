namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsStaticAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsStatic";

		public SDMLIsStaticAttribute(string value) : base(value) { }
	}
}
