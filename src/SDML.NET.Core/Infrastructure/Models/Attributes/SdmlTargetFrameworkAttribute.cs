namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlTargetFrameworkAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "TargetFramework";

		public SdmlTargetFrameworkAttribute(string value) : base(value) { }
	}
}
