using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLField : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Field";

        public SDMLField() : base() { }
        public SDMLField(string value) : base(value) { }
        public SDMLField(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLField(params ISDMLObject[] elements) : base(elements) { }
    }
}
