namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLOverridesBaseAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "OverridesBase";

		public SDMLOverridesBaseAttribute(string value) : base(value) { }
	}
}
