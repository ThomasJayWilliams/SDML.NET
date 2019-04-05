using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDescription : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Description";

        public SDMLDescription() : base() { }
        public SDMLDescription(string value) : base(value) { }
        public SDMLDescription(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLDescription(params ISDMLObject[] elements) : base(elements) { }
    }
}
