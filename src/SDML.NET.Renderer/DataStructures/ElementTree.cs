using SDML.NET.Renderer.VisualComponents;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDML.NET.Renderer
{
	// This structure represents irrational tree of Sdml tags
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

        //wasn't too sure about this but something like a constructor
        public void Create()
        {
            ElementNode node = new ElementNode();
            node.Childs = null;
            node.Parent = null;
            node.Element = null;
            node.Data = null;
            node.Id = null;
        }

        //searches for the node in the list by id and stores it in the result, would need to send it out the result though
        public void Read(ElementNode node)
        {
            if (node != null)
            {
                ElementNode result = elements.Find(o => o.Id == node.Id);
            }
        }

        //searches for the index of the item using the id of the node, and updates the node at index
        public void Update(ElementNode node)
        {
            if (node != null)
            {
                int index = elements.FindIndex(o => o.Id == node.Id);
                elements[index] = node;
            }
        }

        //using remove function of list to delete a node by matching ids
        public void Delete(ElementNode node)
        {
            if (node != null)
                elements.Remove(new ElementNode() { Id = node.Id });
        }
    }

    public class ElementNode
    {
        public SdmlTag Element { get; set; }
        public SdmlTag Parent { get; set; }
        public List<ElementNode> Childs { get; set; }
        public string Data { get; set; }
        public int Id { get; set; }

        public ElementNode()
        {
            Childs = new List<ElementNode>();
        }
    }
}
