﻿using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlDestructor : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Destructor";

        public SdmlDestructor() : base() { }
        public SdmlDestructor(string value) : base(value) { }
        public SdmlDestructor(string value, params ISDMLObject[] elements) : base(value, elements) { }
        public SdmlDestructor(params ISDMLObject[] elements) : base(elements) { }
    }
}
