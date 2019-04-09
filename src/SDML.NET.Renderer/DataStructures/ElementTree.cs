using SDML.NET.Renderer.VisualComponents;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDML.NET.Renderer.DataStructures
{
	// This structure represents irrational tree of SDML tags
    public class ElementTree
    {
        private List<ElementNode> elements { get; }

		// As far as API requires access to this collection for user it has be closed for Add and Remove operations
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
        public SdmlTag Element { get; set; }
        public SdmlTag Parent { get; set; }
        public List<ElementNode> Childs { get; set; }
        public string Data { get; set; }

        public ElementNode()
        {
            Childs = new List<ElementNode>();
        }
    }
}
