using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLProject : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Project";

        public SDMLProject(params ISDMLObject[] elements) : base(elements) { }
        public SDMLProject(string name, params ISDMLObject[] elements) : base(name, elements) { }
    }
}
