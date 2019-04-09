using SDML.NET.Core.Infrastructure.Abstractions;
using System;

namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public abstract class SDMLBaseAttribute : ISDMLAttribute
    {
        public string Value { get; set; }
        public ISDMLDataElement Owner { get; set; }
        public abstract string ObjectName { get; }

        public SDMLBaseAttribute(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!");
            Value = value;
        }
    }
}
