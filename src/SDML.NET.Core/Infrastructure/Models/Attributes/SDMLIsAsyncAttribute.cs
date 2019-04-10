namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
		//Class to mark IsAysnc Object value
	public class SdmlIsAsyncAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsAsync";

		public SdmlIsAsyncAttribute(string value) : base(value) { }
	}
}
