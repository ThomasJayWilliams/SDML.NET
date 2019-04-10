using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlField : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Field";

        public SdmlField() : base() { }
        public SdmlField(string value) : base(value) { }
        public SdmlField(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlField(params ISDMLObject[] elements) : base(elements) { }
    }
}
