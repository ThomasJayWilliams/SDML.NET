using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDelegate : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Delegate";

        public SDMLDelegate() : base() { }
        public SDMLDelegate(string value) : base(value) { }
        public SDMLDelegate(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLDelegate(params ISDMLObject[] elements) : base(elements) { }
    }
}
