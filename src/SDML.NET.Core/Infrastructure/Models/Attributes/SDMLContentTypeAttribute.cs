namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
		// Class represents the ContentType Attribute
	public class SDMLContentTypeAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ContentType";

		public SDMLContentTypeAttribute(string value) : base(value) { }
	}
}
