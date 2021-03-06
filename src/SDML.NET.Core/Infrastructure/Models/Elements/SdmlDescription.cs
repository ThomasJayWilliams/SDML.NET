﻿namespace SDML.NET.Core.Elements
{
    public class SdmlDescription : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Description";

        public SdmlDescription() : base() { }
        public SdmlDescription(string value) : base(value) { }
        public SdmlDescription(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlDescription(params ISdmlObject[] elements) : base(elements) { }
    }
}
