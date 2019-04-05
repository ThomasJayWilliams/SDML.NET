using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDocument : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Document";

        public SDMLDocument() : base() { }
        public SDMLDocument(string value) : base(value) { }
        public SDMLDocument(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLDocument(params ISDMLObject[] elements) : base(elements) { }
    }
}
