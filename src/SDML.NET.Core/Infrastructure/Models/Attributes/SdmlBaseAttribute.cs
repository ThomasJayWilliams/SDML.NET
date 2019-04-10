using System;

namespace SDML.NET.Core.Attributes
{
    public abstract class SdmlBaseAttribute : ISdmlAttribute
    {
        public string Value { get; set; }
        public ISdmlDataElement Owner { get; set; }
        public abstract string ObjectName { get; }

        public SdmlBaseAttribute(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!");
            Value = value;
        }
    }
}
