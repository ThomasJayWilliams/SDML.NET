using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLEnum : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Enum";

        public SDMLEnum(params ISDMLObject[] elements) : base(elements) { }
    }
}
