namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIsCovariantAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsCovariant";

		public SDMLIsCovariantAttribute(string value) : base(value) { }
	}
}
