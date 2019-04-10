namespace SDML.NET.Core.Elements
{
    public class SdmlNamespace : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Namespace";

        public SdmlNamespace() : base() { }
        public SdmlNamespace(string value) : base(value) { }
        public SdmlNamespace(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlNamespace(params ISdmlObject[] elements) : base(elements) { }
    }
}
