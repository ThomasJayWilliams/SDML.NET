using SDML.NET.Renderer.DataStructures;
using System;

namespace SDML.NET.Renderer
{
    public abstract class SDMLBaseRenderer
    {
        public string Data { get; protected set; }

        protected readonly ElementTree elements;

        public SDMLBaseRenderer(ElementTree tree)
        {
            if (elements == null)
                throw new ArgumentException("Tree cannot be null!");
            elements = tree;
        }

        public virtual void Render() => Data = RenderTag(elements.Root);

        protected abstract string RenderTag(ElementNode node);
    }
}
