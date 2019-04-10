using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlStruct : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Struct";

        public SdmlStruct() : base() { }
        public SdmlStruct(string value) : base(value) { }
        public SdmlStruct(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlStruct(params ISDMLObject[] elements) : base(elements) { }
    }
}
