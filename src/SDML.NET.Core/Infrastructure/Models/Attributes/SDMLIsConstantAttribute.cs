namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsConstantAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsConstant";

		public SDMLIsConstantAttribute(string value) : base(value) { }
	}
}
