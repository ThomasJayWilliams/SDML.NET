namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SdmlNamespaceAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "Namespace";

		public SdmlNamespaceAttribute(string value) : base(value) { }
	}
}
