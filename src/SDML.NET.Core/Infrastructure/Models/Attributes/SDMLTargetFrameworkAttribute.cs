namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLTargetFrameworkAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "TargetFramework";

		public SDMLTargetFrameworkAttribute(string value) : base(value) { }
	}
}
