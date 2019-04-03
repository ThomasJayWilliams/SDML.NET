using SDML.NET.Renderer.DTOs;
using System.Collections.Generic;
using System.Text;

namespace SDML.NET.Renderer.VisualComponents
{
	public class SDMLBodyTag : SDMLBaseTag
    {
        public string OpenTag { get; }
        public string CloseTag { get; }

        public SDMLBodyTag(IEnumerable<DataAttributeDTO> attributes, DataElementDTO element) : base(attributes, element) { }

        public override void Parse()
        {
            if (Element != null)
            {
                var tag = new StringBuilder();
                var attributes = new StringBuilder();

                foreach (var attr in Attributes)
                    attributes.Append($" {attr.ObjectName} = {attr.Value}");
                
                // <Solution>...
                tag.Append($"{Constants.BodyOpenTagBeginSymbol}{Element.ObjectName}");
                tag.Append(attributes);
                tag.Append($" {Constants.BodyOpenTagEndSymbol}");

                //</Solution>
                tag.Append($"{Constants.BodyCloseTagBeginSymbol}{Element.ObjectName}{Constants.BodyCloseTagEndSymbol}");

                Data = tag.ToString();
            }
        }
    }
}
