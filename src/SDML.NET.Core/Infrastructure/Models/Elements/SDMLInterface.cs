using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlInterface : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Interface";

        public SdmlInterface() : base() { }
        public SdmlInterface(string value) : base(value) { }
        public SdmlInterface(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlInterface(params ISDMLObject[] elements) : base(elements) { }
    }
}
