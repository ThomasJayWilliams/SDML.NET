using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLConstructor : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Constructor";

        public SDMLConstructor() : base() { }
        public SDMLConstructor(string value) : base(value) { }
        public SDMLConstructor(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLConstructor(params ISDMLObject[] elements) : base(elements) { }
    }
}
