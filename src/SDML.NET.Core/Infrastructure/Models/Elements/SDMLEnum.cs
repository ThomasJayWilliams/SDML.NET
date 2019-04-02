using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLEnum : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Enum";

        public SDMLEnum(params ISDMLObject[] elements) : base(elements) { }
        public SDMLEnum(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
