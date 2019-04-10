using SDML.NET.Core.Infrastructure.Abstractions;
using System;

namespace SDML.NET.Core.Infrastructure.Models.Attributes
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
