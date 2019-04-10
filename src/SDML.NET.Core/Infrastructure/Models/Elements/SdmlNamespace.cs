using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlNamespace : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Namespace";

        public SdmlNamespace() : base() { }
        public SdmlNamespace(string value) : base(value) { }
        public SdmlNamespace(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlNamespace(params ISDMLObject[] elements) : base(elements) { }
    }
}
