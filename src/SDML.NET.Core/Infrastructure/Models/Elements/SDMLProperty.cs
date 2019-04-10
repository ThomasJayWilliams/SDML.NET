using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlProperty : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Property";

        public SdmlProperty() : base() { }
        public SdmlProperty(string value) : base(value) { }
        public SdmlProperty(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlProperty(params ISdmlObject[] elements) : base(elements) { }
    }
}
