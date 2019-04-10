using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlProject : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Project";

        public SdmlProject() : base() { }
        public SdmlProject(string value) : base(value) { }
        public SdmlProject(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlProject(params ISdmlObject[] elements) : base(elements) { }
    }
}
