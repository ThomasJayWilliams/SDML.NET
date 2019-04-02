using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLClass : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Class";

        public SDMLClass(params ISDMLObject[] elements) : base(elements) { }
        public SDMLClass(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
