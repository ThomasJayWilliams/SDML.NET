using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLClass : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Class";

        public SDMLClass() : base() { }
        public SDMLClass(string value) : base(value) { }
        public SDMLClass(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLClass(params ISDMLObject[] elements) : base(elements) { }
    }
}
