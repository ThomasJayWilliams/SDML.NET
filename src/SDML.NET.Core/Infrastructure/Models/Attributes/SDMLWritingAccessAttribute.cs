namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLWritingAccessAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "WritingAccess";

		public SDMLWritingAccessAttribute(string value) : base(value) { }
	}
}
