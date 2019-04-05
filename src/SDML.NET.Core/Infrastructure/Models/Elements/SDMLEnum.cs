using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLEnum : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Enum";

        public SDMLEnum() : base() { }
        public SDMLEnum(string value) : base(value) { }
        public SDMLEnum(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLEnum(params ISDMLObject[] elements) : base(elements) { }
    }
}
