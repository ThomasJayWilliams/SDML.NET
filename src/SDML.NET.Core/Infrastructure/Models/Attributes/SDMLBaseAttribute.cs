using SDML.NET.Core.Infrastructure.Abstractions;
using System;

namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public abstract class SdmlBaseAttribute : ISDMLAttribute
    {
        public string Value { get; set; }
        public ISDMLDataElement Owner { get; set; }
        public abstract string ObjectName { get; }

        public SdmlBaseAttribute(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!");
            Value = value;
        }
    }
}
