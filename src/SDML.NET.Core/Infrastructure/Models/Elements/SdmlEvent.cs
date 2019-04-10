namespace SDML.NET.Core.Elements
{
	public class SdmlEvent : SdmlBaseElement
	{
		public override string ObjectName { get; } = "Event";

		public SdmlEvent() : base() { }
		public SdmlEvent(string value) : base(value) { }
		public SdmlEvent(string value, params ISdmlObject[] elements) : base(value, elements) { }
		public SdmlEvent(params ISdmlObject[] elements) : base(elements) { }
	}
}
