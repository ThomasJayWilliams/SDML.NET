using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDependency : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Dependency";

        public SDMLDependency(params ISDMLObject[] elements) : base(elements) { }
    }
}
