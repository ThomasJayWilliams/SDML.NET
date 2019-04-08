namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
		// Class that gets ContentType element of the SDML base attribute
	public class SDMLContentTypeAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ContentType";

		public SDMLContentTypeAttribute(string value) : base(value) { }
	}
}
