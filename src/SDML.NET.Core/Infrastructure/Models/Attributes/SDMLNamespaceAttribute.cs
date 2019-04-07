namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLNamespaceAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "Namespace";

		public SDMLNamespaceAttribute(string value) : base(value) { }
	}
}
