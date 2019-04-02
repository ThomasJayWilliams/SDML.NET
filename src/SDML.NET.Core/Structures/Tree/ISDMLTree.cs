using System.Collections.Generic;
using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Structures
{
    public interface ISDMLTree
    {
        ISDMLNode Root { get; }
        Dictionary<string, ISDMLNode> Nodes { get; }
    }

    public interface ISDMLNode
    {
        ISDMLDataElement Data { get; set; }
        ISDMLNode Parent { get; set; }
        Dictionary<string, ISDMLNode> Children { get; set; }
    }
}
