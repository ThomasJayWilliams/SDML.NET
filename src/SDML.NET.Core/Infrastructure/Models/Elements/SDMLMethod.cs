﻿using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlMethod : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Method";

        public SdmlMethod() : base() { }
        public SdmlMethod(string value) : base(value) { }
        public SdmlMethod(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlMethod(params ISDMLObject[] elements) : base(elements) { }
    }
}
