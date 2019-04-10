namespace SDML.NET.Core.Attributes
{
	//Class to mark IsAysnc Object value
	public class SdmlIsAsyncAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsAsync";

		public SdmlIsAsyncAttribute(string value) : base(value) { }
	}
}
