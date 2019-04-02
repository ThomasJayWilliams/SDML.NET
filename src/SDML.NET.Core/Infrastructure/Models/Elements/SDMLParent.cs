using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLParent : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Parent";

        public SDMLParent(params ISDMLObject[] elements) : base(elements) { }
        public SDMLParent(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
