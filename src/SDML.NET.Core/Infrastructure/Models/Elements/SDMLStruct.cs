using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLStruct : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Struct";

        public SDMLStruct() : base() { }
        public SDMLStruct(string value) : base(value) { }
        public SDMLStruct(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLStruct(params ISDMLObject[] elements) : base(elements) { }
    }
}
