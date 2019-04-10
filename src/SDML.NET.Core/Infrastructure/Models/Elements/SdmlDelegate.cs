namespace SDML.NET.Core.Elements
{
    public class SdmlDelegate : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Delegate";

        public SdmlDelegate() : base() { }
        public SdmlDelegate(string value) : base(value) { }
        public SdmlDelegate(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlDelegate(params ISdmlObject[] elements) : base(elements) { }
    }
}
