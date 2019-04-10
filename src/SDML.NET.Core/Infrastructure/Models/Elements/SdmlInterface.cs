namespace SDML.NET.Core.Elements
{
    public class SdmlInterface : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Interface";

        public SdmlInterface() : base() { }
        public SdmlInterface(string value) : base(value) { }
        public SdmlInterface(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlInterface(params ISdmlObject[] elements) : base(elements) { }
    }
}
