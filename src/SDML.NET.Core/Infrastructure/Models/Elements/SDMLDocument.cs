using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDocument : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Document";

        public SDMLDocument(params ISDMLObject[] elements) : base(elements) { }
        public SDMLDocument(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
