using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDependency : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Dependency";

        public SDMLDependency() : base() { }
        public SDMLDependency(string value) : base(value) { }
        public SDMLDependency(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLDependency(params ISDMLObject[] elements) : base(elements) { }
    }
}
