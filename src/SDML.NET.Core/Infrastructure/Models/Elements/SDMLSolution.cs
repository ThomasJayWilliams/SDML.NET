using SDML.NET.Core.Infrastructure.Abstractions;
using System.Collections.Generic;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLSolution : SDMLBaseElement
    {
        public override string ObjectName { get; } = "Solution";

        public SDMLSolution(params ISDMLObject[] elements) : base(elements) { }
    }
}
