using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLDestructor : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Destructor";

        public SDMLDestructor() : base() { }
        public SDMLDestructor(string value) : base(value) { }
        public SDMLDestructor(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLDestructor(params ISDMLObject[] elements) : base(elements) { }
    }
}
