using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLConstructor : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Constructor";

        public SDMLConstructor(params ISDMLObject[] elements) : base(elements) { }
        public SDMLConstructor(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
