using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlParameter : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Parameter";

        public SdmlParameter() : base() { }
        public SdmlParameter(string value) : base(value) { }
        public SdmlParameter(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlParameter(params ISDMLObject[] elements) : base(elements) { }
    }
}
