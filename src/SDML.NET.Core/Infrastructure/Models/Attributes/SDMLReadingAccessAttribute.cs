namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
	public class SDMLReadingAccessAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "ReadingAccess";

		public SDMLReadingAccessAttribute(string value) : base(value) { }
	}
}
