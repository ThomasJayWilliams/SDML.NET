using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlDelegate : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Delegate";

        public SdmlDelegate() : base() { }
        public SdmlDelegate(string value) : base(value) { }
        public SdmlDelegate(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlDelegate(params ISDMLObject[] elements) : base(elements) { }
    }
}
