namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsVirtualAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsVirtual";

		public SDMLIsVirtualAttribute(string value) : base(value) { }
	}
}
