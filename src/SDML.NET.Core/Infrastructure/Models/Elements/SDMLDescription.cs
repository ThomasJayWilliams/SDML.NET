using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDescription : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Description";

        public SDMLDescription(params ISDMLObject[] elements) : base(elements) { }
    }
}
