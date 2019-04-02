using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLInterface : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Interface";

        public SDMLInterface(params ISDMLObject[] elements) : base(elements) { }
        public SDMLInterface(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
