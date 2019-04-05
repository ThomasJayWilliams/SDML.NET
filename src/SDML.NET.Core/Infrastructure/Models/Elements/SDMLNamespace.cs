using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLNamespace : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Namespace";

        public SDMLNamespace() : base() { }
        public SDMLNamespace(string value) : base(value) { }
        public SDMLNamespace(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLNamespace(params ISDMLObject[] elements) : base(elements) { }
    }
}
