using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Exceptions;
using System.Collections.Generic;

namespace SDML.NET.Core.Structures
{
    public class SDMLTree : ISDMLTree
    {
        public ISDMLNode Root { get; }
        public Dictionary<string, ISDMLNode> Nodes { get; }

        private SDMLTree(ISDMLNode root)
        {
            
        }

        public SDMLTree(ISDMLDataElement root) : this(new SDMLNode(root)) { }

        // TODO: Implement adding logic - beside node parent must by pointed
        public void AddNode(ISDMLNode node)
        {
            
        }

        // TODO: Check if parent type is allowed in the AllowedParentElements
        public bool IsParentValid(ISDMLDataElement parent, ISDMLDataElement node)
        {
            return false;
        }

        public void RemoveNode(ISDMLDataElement node) { }

        public void RemoveNode(ISDMLNode node) { }

        public void RemoveNode(string name)
        {
            
        }
    }

    public class SDMLNode : ISDMLNode
    {
        public ISDMLDataElement Data { get; set; }
        public ISDMLNode Parent { get; set; }
        public Dictionary<string, ISDMLNode> Children { get; set; }

        public SDMLNode() { }

        public SDMLNode(ISDMLDataElement data)
        {
            Data = data;
        }
    }
}
