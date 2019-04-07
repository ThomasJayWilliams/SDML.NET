namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLVersionAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "Version";

		public SDMLVersionAttribute(string value) : base(value) { }
	}
}
