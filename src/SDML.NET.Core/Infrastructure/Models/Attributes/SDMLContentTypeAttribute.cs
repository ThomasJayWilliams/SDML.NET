namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLContentTypeAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ContentType";

		public SDMLContentTypeAttribute(string value) : base(value) { }
	}
}
