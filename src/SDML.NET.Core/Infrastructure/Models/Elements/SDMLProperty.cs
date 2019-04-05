using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLProperty : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Property";

        public SDMLProperty() : base() { }
        public SDMLProperty(string value) : base(value) { }
        public SDMLProperty(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLProperty(params ISDMLObject[] elements) : base(elements) { }
    }
}
