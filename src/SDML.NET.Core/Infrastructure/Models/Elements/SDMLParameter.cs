using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLParameter : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Parameter";

        public SDMLParameter() : base() { }
        public SDMLParameter(string value) : base(value) { }
        public SDMLParameter(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLParameter(params ISDMLObject[] elements) : base(elements) { }
    }
}
