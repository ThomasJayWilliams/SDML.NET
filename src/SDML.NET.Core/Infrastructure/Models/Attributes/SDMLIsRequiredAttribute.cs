namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsRequiredAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsRequired";

		public SDMLIsRequiredAttribute(string value) : base(value) { }
	}
}
