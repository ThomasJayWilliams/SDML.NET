using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDirectory : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Directory";

        public SDMLDirectory(params ISDMLObject[] elements) : base(elements) { }
    }
}
