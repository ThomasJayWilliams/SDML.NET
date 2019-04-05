using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLInterface : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Interface";

        public SDMLInterface() : base() { }
        public SDMLInterface(string value) : base(value) { }
        public SDMLInterface(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLInterface(params ISDMLObject[] elements) : base(elements) { }
    }
}
