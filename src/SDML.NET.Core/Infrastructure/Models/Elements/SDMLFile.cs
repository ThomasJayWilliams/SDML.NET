using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLFile : SDMLBaseElement
    {
        public override string ObjectName { get; } = "File";

        public SDMLFile(params ISDMLObject[] elements) : base(elements) { }
    }
}
