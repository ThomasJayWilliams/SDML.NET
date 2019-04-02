using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLField : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Field";

        public SDMLField(params ISDMLObject[] elements) : base(elements) { }
        public SDMLField(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
