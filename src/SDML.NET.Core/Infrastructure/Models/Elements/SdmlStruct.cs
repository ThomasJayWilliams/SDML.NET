namespace SDML.NET.Core.Elements
{
    public class SdmlStruct : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Struct";

        public SdmlStruct() : base() { }
        public SdmlStruct(string value) : base(value) { }
        public SdmlStruct(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlStruct(params ISdmlObject[] elements) : base(elements) { }
    }
}
