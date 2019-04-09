﻿using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlDocument : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Document";

        public SdmlDocument() : base() { }
        public SdmlDocument(string value) : base(value) { }
        public SdmlDocument(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlDocument(params ISDMLObject[] elements) : base(elements) { }
    }
}
