namespace SDML.NET.Core.Attributes
{
	public class SdmlIsCovariantAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "IsCovariant";

		public SdmlIsCovariantAttribute(string value) : base(value) { }
	}
}
