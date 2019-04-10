namespace SDML.NET.Core.Elements
{
    public class SdmlSolution : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Solution";

        public SdmlSolution() : base() { }
        public SdmlSolution(string value) : base(value) { }
        public SdmlSolution(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlSolution(params ISdmlObject[] elements) : base(elements) { }
    }
}
