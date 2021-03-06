﻿namespace SDML.NET.Core.Elements
{
    public class SdmlParameter : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Parameter";

        public SdmlParameter() : base() { }
        public SdmlParameter(string value) : base(value) { }
        public SdmlParameter(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlParameter(params ISdmlObject[] elements) : base(elements) { }
    }
}
