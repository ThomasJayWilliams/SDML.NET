namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLValueAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "Value";

		public SDMLValueAttribute(string value) : base(value) { }
	}
}
