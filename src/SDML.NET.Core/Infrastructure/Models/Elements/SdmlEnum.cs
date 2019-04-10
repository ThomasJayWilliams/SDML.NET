namespace SDML.NET.Core.Elements
{
    public class SdmlEnum : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Enum";

        public SdmlEnum() : base() { }
        public SdmlEnum(string value) : base(value) { }
        public SdmlEnum(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlEnum(params ISdmlObject[] elements) : base(elements) { }
    }
}
