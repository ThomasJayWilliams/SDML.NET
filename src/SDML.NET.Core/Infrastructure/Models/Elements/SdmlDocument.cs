namespace SDML.NET.Core.Elements
{
    public class SdmlDocument : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Document";

        public SdmlDocument() : base() { }
        public SdmlDocument(string value) : base(value) { }
        public SdmlDocument(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlDocument(params ISdmlObject[] elements) : base(elements) { }
    }
}
