namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsReadonlyAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsReadonly";

		public SDMLIsReadonlyAttribute(string value) : base(value) { }
	}
}
