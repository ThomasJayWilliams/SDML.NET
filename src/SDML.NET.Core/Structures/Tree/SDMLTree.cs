using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Exceptions;
using System.Collections.Generic;

namespace SDML.NET.Core.Structures
{
    public class SDMLTree : ISDMLTree<ISDMLObject>
    {
        private ISDMLNode<ISDMLObject> root;
        private Dictionary<string, ISDMLNode<ISDMLObject>> nodes;

        public ISDMLNode<ISDMLObject> Root { get => root; }
        public Dictionary<string, ISDMLNode<ISDMLObject>> Nodes { get => nodes; }

        private SDMLTree(ISDMLNode<ISDMLObject> root)
        {
            nodes = new Dictionary<string, ISDMLNode<ISDMLObject>>();
            nodes.Add(root.Data.Name, root);
        }

        public SDMLTree(ISDMLObject root) : this(new SDMLNode(root)) { }

        public void AddNode(ISDMLNode<ISDMLObject> node)
        {
            if (node != null)
                nodes.Add(node.Data.Name, node);
        }

        public void RemoveNode(ISDMLObject node) => RemoveNode(node?.Name);

        public void RemoveNode(ISDMLNode<ISDMLObject> node) => RemoveNode(node?.Data?.Name);

        public void RemoveNode(string name)
        {
            if (!string.IsNullOrEmpty(name))
                nodes.Remove(name);
        }

        public ISDMLNode<ISDMLObject> GetNode(string name)
        {
            if (!string.IsNullOrEmpty(name))
                return nodes[name];
            throw new InvalidNodeException("Invalid node identifier!");
        }

        public ISDMLNode<ISDMLObject> GetNode(ISDMLObject data) => GetNode(data?.Name);
    }

    public class SDMLNode : ISDMLNode<ISDMLObject>
    {
        public ISDMLObject Data { get; set; }
        public ISDMLNode<ISDMLObject> Parent { get; set; }
        public Dictionary<string, ISDMLNode<ISDMLObject>> Child { get; set; }

        public SDMLNode() { }

        public SDMLNode(ISDMLObject data)
        {
            Data = data;
        }
    }
}
