namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLReturnTypeAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ReturnType";

		public SDMLReturnTypeAttribute(string value) : base(value) { }
	}
}
