namespace SDML.NET.Core.Elements
{
    public class SdmlMethod : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Method";

        public SdmlMethod() : base() { }
        public SdmlMethod(string value) : base(value) { }
        public SdmlMethod(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlMethod(params ISdmlObject[] elements) : base(elements) { }
    }
}
