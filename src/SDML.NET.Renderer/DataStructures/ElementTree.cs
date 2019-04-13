using SDML.NET.Renderer.VisualComponents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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

        //searches for the node in the list by id and stores it in the result, would need to send it out the result though
        public ElementNode Read(int id)
        {
			if (id > 0)
				return Elements.FirstOrDefault(e => e.Id == id);
			throw new ArgumentException("Element Id cannot be less then zero or be equal to zero!");
        }

        //searches for the index of the item using the id of the node, and updates the node at index
        public void Update(ElementNode node)
        {
            if (node != null)
            {
                int index = elements.FindIndex(o => o.Id == node.Id);
				elements[index].Childs = node.Childs;
				elements[index].Data = node.Data;
				elements[index].Element = node.Element;
				elements[index].Parent = node.Parent;
            }
			throw new ArgumentException("Element cannot be null!");
        }

        //using remove function of list to delete a node by matching ids
        public void Delete(int id)
        {
			if (id > 0)
			{
				var element = elements.FirstOrDefault(e => e.Id == id);

				if (element == null)
					throw new ElementNotFoundException("Element with this id does not exist!");

				Delete(element);
			}

			throw new ArgumentException("Element id must be greater then zero!");
        }

		public void Delete(ElementNode element)
		{
			if (element == null)
				throw new ArgumentException("Element cannot be null!");

			elements.Remove(element);
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
