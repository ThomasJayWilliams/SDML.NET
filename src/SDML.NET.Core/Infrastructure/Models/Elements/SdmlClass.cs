using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlClass : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Class";

        public SdmlClass() : base() { }
        public SdmlClass(string value) : base(value) { }
        public SdmlClass(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlClass(params ISDMLObject[] elements) : base(elements) { }
    }
}
