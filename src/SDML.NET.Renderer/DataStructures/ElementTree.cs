using SDML.NET.Renderer.VisualComponents;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDML.NET.Renderer.DataStructures
{
    public class ElementTree
    {
        private List<ElementNode> elements { get; }

        public ReadOnlyCollection<ElementNode> Elements
        {
            get { return new ReadOnlyCollection<ElementNode>(elements); }
        }
        public ElementNode Root { get; private set; }

        public ElementTree()
        {
            elements = new List<ElementNode>();
        }

        public void AddRange(ElementTree source)
        {
            if (source != null)
                elements.AddRange(source.elements);
            if (Root == null)
                Root = source.Root;
        }

        public void Add(ElementNode node)
        {
            if (node != null)
                elements.Add(node);
            if (Root == null)
                Root = node;
        }
    }

    public class ElementNode
    {
        public SDMLBaseTag Element { get; set; }
        public SDMLBaseTag Parent { get; set; }
        public List<ElementNode> Childs { get; set; }
        public string Data { get; set; }

        public ElementNode()
        {
            Childs = new List<ElementNode>();
        }
    }
}
