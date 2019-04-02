using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDestructor : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Destructor";

        public SDMLDestructor(params ISDMLObject[] elements) : base(elements) { }
    }
}
