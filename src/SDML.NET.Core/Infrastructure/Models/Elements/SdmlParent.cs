namespace SDML.NET.Core.Elements
{
    public class SdmlParent : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Parent";

        public SdmlParent() : base() { }
        public SdmlParent(string value) : base(value) { }
        public SdmlParent(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlParent(params ISdmlObject[] elements) : base(elements) { }
    }
}
