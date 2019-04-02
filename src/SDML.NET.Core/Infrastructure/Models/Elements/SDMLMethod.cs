using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLMethod : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Method";

        public SDMLMethod(params ISDMLObject[] elements) : base(elements) { }
        public SDMLMethod(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
