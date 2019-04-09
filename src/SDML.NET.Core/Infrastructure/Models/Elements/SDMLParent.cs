﻿using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlParent : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Parent";

        public SdmlParent() : base() { }
        public SdmlParent(string value) : base(value) { }
        public SdmlParent(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlParent(params ISDMLObject[] elements) : base(elements) { }
    }
}
