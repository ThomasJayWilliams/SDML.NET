using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlEnum : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Enum";

        public SdmlEnum() : base() { }
        public SdmlEnum(string value) : base(value) { }
        public SdmlEnum(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlEnum(params ISDMLObject[] elements) : base(elements) { }
    }
}
