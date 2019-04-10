using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlDependency : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Dependency";

        public SdmlDependency() : base() { }
        public SdmlDependency(string value) : base(value) { }
        public SdmlDependency(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlDependency(params ISDMLObject[] elements) : base(elements) { }
    }
}
