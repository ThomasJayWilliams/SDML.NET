using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLProject : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Project";

        public SDMLProject() : base() { }
        public SDMLProject(string value) : base(value) { }
        public SDMLProject(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SDMLProject(params ISDMLObject[] elements) : base(elements) { }
    }
}
