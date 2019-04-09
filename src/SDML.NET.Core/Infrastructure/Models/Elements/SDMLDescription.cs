using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlDescription : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Description";

        public SdmlDescription() : base() { }
        public SdmlDescription(string value) : base(value) { }
        public SdmlDescription(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlDescription(params ISDMLObject[] elements) : base(elements) { }
    }
}
