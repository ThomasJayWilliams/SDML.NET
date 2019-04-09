namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
		//Class to mark IsAysnc Object value
	public class SDMLIsAsyncAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsAsync";

		public SDMLIsAsyncAttribute(string value) : base(value) { }
	}
}
