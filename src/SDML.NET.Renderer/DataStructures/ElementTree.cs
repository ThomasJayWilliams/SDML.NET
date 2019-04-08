using SDML.NET.Renderer.VisualComponents;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDML.NET.Renderer.DataStructures
{
    public class ElementTree
    {
        public List<ElementNode> Elements { get; }

        public ElementTree()
        {
            Elements = new List<ElementNode>();
        }

        public void AddRange(ElementTree source)
        {
            if (source != null)
                Elements.AddRange(source.Elements);
        }

        public void Add(ElementNode node)
        {
            if (node != null)
                Elements.Add(node);
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
