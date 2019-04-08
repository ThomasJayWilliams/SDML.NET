using SDML.NET.Renderer.DTOs;
using System.Text;

namespace SDML.NET.Renderer.VisualComponents
{
    public class SDMLBodyTag : SDMLBaseTag
    {
        public string OpenTag { get; private set; }
        public string CloseTag { get; private set; }

        public SDMLBodyTag(DataElementDTO data) : base(data) { }

        protected override void Parse()
        {
            if (Object != null)
            {
                var tag = new StringBuilder();
                var attributes = new StringBuilder();

                foreach (var attr in Object.Attributes)
                    attributes.Append($" {attr.ObjectName}=\"{attr.Value}\"");

                // <Solution>...
                tag.Append($"{Constants.BodyOpenTagBeginSymbol}{Object.ObjectName}");
                tag.Append(attributes);
                tag.Append($"{Constants.BodyOpenTagEndSymbol}");

                OpenTag = tag.ToString();
                tag.Clear();

                // </Solution>
                tag.Append($"{Constants.BodyCloseTagBeginSymbol}{Object.ObjectName}{Constants.BodyCloseTagEndSymbol}");
                CloseTag = tag.ToString();
            }
        }
    }
}
