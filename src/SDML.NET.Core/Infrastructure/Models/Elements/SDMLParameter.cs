using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLParameter : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Parameter";

        public SDMLParameter(params ISDMLObject[] elements) : base(elements) { }
    }
}
