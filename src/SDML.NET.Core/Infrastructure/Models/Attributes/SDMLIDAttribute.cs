namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLIDAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ID";

		public SDMLIDAttribute(string value) : base(value) { }
	}
}
