using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public abstract class SDMLBaseAttribute : ISDMLAttribute
    {
        public string Value { get; set; }
        public ISDMLDataElement Owner { get; set; }
        public abstract string ObjectName { get; }

        public SDMLBaseAttribute(string value)
        {
            Value = value;
        }
    }
}
