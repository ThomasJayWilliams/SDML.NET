using SDML.NET.Renderer.DTOs;
using System.Collections.Generic;
using System.Text;

namespace SDML.NET.Renderer.VisualComponents
{
	public class SDMLBodylessTag : SDMLBaseTag
	{
		public SDMLBodylessTag(IEnumerable<DataAttributeDTO> attributes, DataElementDTO element) : base(attributes, element) { }

        public override void Parse()
        {
            if (Element != null)
            {
                var tag = new StringBuilder();
                var attributes = new StringBuilder();

                foreach (var attr in Attributes)
                    attributes.Append($" {attr.ObjectName} = {attr.Value}");
                
                // <Solution />
                tag.Append($"{Constants.BodylessTagBeginSymbol}{Element.ObjectName}");
                tag.Append(attributes);
                tag.Append($" {Constants.BodylessTagEndSymbol}");

                Data = tag.ToString();
            }
        }
    }
}
