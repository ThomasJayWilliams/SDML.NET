using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlConstructor : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Constructor";

        public SdmlConstructor() : base() { }
        public SdmlConstructor(string value) : base(value) { }
        public SdmlConstructor(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlConstructor(params ISDMLObject[] elements) : base(elements) { }
    }
}
