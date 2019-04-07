namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsAbstractAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsAbstract";

		public SDMLIsAbstractAttribute(string value) : base(value) { }
	}
}
