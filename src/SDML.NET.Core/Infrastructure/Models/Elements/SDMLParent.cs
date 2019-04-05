using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLParent : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Parent";

        public SDMLParent() : base() { }
        public SDMLParent(string value) : base(value) { }
        public SDMLParent(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLParent(params ISDMLObject[] elements) : base(elements) { }
    }
}
