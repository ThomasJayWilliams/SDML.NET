using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLMethod : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Method";

        public SDMLMethod() : base() { }
        public SDMLMethod(string value) : base(value) { }
        public SDMLMethod(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLMethod(params ISDMLObject[] elements) : base(elements) { }
    }
}
