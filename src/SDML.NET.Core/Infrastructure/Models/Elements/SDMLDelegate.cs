using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDelegate : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Delegate";

        public SDMLDelegate(params ISDMLObject[] elements) : base(elements) { }
    }
}
