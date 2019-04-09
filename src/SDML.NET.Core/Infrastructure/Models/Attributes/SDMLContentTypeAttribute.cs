namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
		// Class that allows users to add attribute as plain value
	public class SDMLContentTypeAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ContentType";

		public SDMLContentTypeAttribute(string value) : base(value) { }
	}
}
