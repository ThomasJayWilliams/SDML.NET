using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLSolution : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Solution";

        public SDMLSolution() : base() { }
        public SDMLSolution(string value) : base(value) { }
        public SDMLSolution(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLSolution(params ISDMLObject[] elements) : base(elements) { }
    }
}
