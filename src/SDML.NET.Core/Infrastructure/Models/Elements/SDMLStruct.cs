using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLStruct : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Struct";

        public SDMLStruct(params ISDMLObject[] elements) : base(elements) { }
    }
}
