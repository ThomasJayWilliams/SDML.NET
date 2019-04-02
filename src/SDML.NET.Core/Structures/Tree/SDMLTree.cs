using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Exceptions;
using System.Collections.Generic;

namespace SDML.NET.Core.Structures
{
    public class SDMLTree : ISDMLTree<ISDMLDataElement>
    {
        private ISDMLNode<ISDMLDataElement> root;
        private Dictionary<string, ISDMLNode<ISDMLDataElement>> nodes;

        public ISDMLNode<ISDMLDataElement> Root { get => root; }
        public Dictionary<string, ISDMLNode<ISDMLDataElement>> Nodes { get => nodes; }

        private SDMLTree(ISDMLNode<ISDMLDataElement> root)
        {
            nodes = new Dictionary<string, ISDMLNode<ISDMLDataElement>>();
            nodes.Add(root.Data.ElementName, root);
        }

        public SDMLTree(ISDMLDataElement root) : this(new SDMLNode(root)) { }

        public void AddNode(ISDMLNode<ISDMLDataElement> node)
        {
            if (node != null)
                nodes.Add(node.Data.ElementName, node);
        }

        public void RemoveNode(ISDMLDataElement node) => RemoveNode(node?.ElementName);

        public void RemoveNode(ISDMLNode<ISDMLDataElement> node) => RemoveNode(node?.Data?.ElementName);

        public void RemoveNode(string name)
        {
            if (!string.IsNullOrEmpty(name))
                nodes.Remove(name);
        }

        public ISDMLNode<ISDMLDataElement> GetNode(string name)
        {
            if (!string.IsNullOrEmpty(name))
                return nodes[name];
            throw new InvalidNodeException("Invalid node identifier!");
        }

        public ISDMLNode<ISDMLDataElement> GetNode(ISDMLDataElement data) => GetNode(data?.ElementName);
    }

    public class SDMLNode : ISDMLNode<ISDMLDataElement>
    {
        public ISDMLDataElement Data { get; set; }
        public ISDMLNode<ISDMLDataElement> Parent { get; set; }
        public Dictionary<string, ISDMLNode<ISDMLDataElement>> Child { get; set; }

        public SDMLNode() { }

        public SDMLNode(ISDMLDataElement data)
        {
            Data = data;
        }
    }
}
