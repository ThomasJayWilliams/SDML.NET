using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLReference : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Reference";

        public SDMLReference(params ISDMLObject[] elements) : base(elements) { }
        public SDMLReference(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
