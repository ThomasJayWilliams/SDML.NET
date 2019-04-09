﻿using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlReference : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Reference";

        public SdmlReference() : base() { }
        public SdmlReference(string value) : base(value) { }
        public SdmlReference(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlReference(params ISDMLObject[] elements) : base(elements) { }
    }
}
