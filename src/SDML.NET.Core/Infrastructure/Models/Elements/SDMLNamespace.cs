using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLNamespace : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Namespace";

        public SDMLNamespace(params ISDMLObject[] elements) : base(elements) { }
        public SDMLNamespace(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
