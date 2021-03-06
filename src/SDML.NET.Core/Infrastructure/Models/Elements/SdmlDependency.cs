﻿namespace SDML.NET.Core.Elements
{
    public class SdmlDependency : SdmlBaseElement
    {
        public override string ObjectName { get; } = "Dependency";

        public SdmlDependency() : base() { }
        public SdmlDependency(string value) : base(value) { }
        public SdmlDependency(string value, params ISdmlObject[] elements) : base(value, elements) { }
        public SdmlDependency(params ISdmlObject[] elements) : base(elements) { }
    }
}
