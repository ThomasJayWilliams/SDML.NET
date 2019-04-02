using SDML.NET.Core.Infrastructure.Abstractions;
using System.Text;

namespace SDML.NET.Renderer.VisualComponents
{
    public class SDMLBodyTag : SDMLBaseTag
    {
        public ISDMLDataElement Source { get; }
        public string OpenTag { get; }
        public string CloseTag { get; }

        public SDMLBodyTag(ISDMLDataElement element)
        {
            Source = element;
            Parse();
        }

        public override void Parse()
        {
            if (Source != null)
            {
                var tag = new StringBuilder();
                var attributes = new StringBuilder();

                foreach (var attr in Source.Attributes)
                    attributes.Append($" {attr.ObjectName} = {attr.Value}");
                
                // <Solution>...
                tag.Append($"{Constants.BodyOpenTagBeginSymbol}{Source.ObjectName}");
                tag.Append(attributes);
                tag.Append($" {Constants.BodyOpenTagEndSymbol}");

                //</Solution>
                tag.Append($"{Constants.BodyCloseTagBeginSymbol}{Source.ObjectName}{Constants.BodyCloseTagEndSymbol}");

                Data = tag.ToString();
            }
        }
    }
}
