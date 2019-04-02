using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLProperty : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Property";

        public SDMLProperty(params ISDMLObject[] elements) : base(elements) { }
    }
}
