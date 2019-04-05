using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLReference : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Reference";

        public SDMLReference() : base() { }
        public SDMLReference(string value) : base(value) { }
        public SDMLReference(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLReference(params ISDMLObject[] elements) : base(elements) { }
    }
}
