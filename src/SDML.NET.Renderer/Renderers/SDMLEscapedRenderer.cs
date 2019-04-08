using SDML.NET.Renderer.DataStructures;
using SDML.NET.Renderer.VisualComponents;
using System.Linq;
using System.Text;

namespace SDML.NET.Renderer
{
    public class SDMLEscapedRenderer : SDMLBaseRenderer
    {
        public SDMLEscapedRenderer(ElementTree tree) : base(tree) { }

        protected override string RenderTag(ElementNode node)
        {
            var builder = new StringBuilder();

            if (node.Element.GetType() == typeof(SDMLBodylessTag))
            {
                builder.Append(((SDMLBodylessTag)node.Element).Tag);
            }

            else if (node.Element.GetType() == typeof(SDMLBodyTag))
            {
                var bodyTag = (SDMLBodyTag)node.Element;

                builder.Append(bodyTag.OpenTag);

                if (!string.IsNullOrEmpty(bodyTag.Element.Value))
                {
                    builder.Append(bodyTag.Element.Value);
                }

                else if (node.Childs.Any())
                {
                    foreach (var child in node.Childs)
                        builder.Append(RenderTag(child));
                }

                builder.Append(bodyTag.CloseTag);
            }

            return builder.ToString();
        }
    }
}
