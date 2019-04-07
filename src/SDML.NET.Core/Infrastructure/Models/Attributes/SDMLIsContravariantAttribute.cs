namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsContravariantAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsContravariant";

		public SDMLIsContravariantAttribute(string value) : base(value) { }
	}
}
