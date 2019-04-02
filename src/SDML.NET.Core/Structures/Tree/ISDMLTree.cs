using System.Collections.Generic;

namespace SDML.NET.Core.Structures
{
    public interface ISDMLTree<T>
    {
        ISDMLNode<T> Root { get; }
        Dictionary<string, ISDMLNode<T>> Nodes { get; }
    }

    public interface ISDMLNode<T>
    {
        T Data { get; set; }
        ISDMLNode<T> Parent { get; set; }
        Dictionary<string, ISDMLNode<T>> Child { get; set; }
    }
}
