namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
		//Class to mark the IsAbstract Value
	public class SdmlIsAbstractAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsAbstract";

		public SdmlIsAbstractAttribute(string value) : base(value) { }
	}
}
