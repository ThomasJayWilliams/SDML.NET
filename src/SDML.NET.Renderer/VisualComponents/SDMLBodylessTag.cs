using SDML.NET.Core.Infrastructure.Abstractions;
using System.Text;

namespace SDML.NET.Renderer.VisualComponents
{
    public class SDMLBodylessTag : SDMLBaseTag
    {
        public ISDMLDataElement Source { get; }

        public SDMLBodylessTag(ISDMLDataElement element)
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
                
                // <Solution />
                tag.Append($"{Constants.BodylessTagBeginSymbol}{Source.ObjectName}");
                tag.Append(attributes);
                tag.Append($" {Constants.BodylessTagEndSymbol}");

                Data = tag.ToString();
            }
        }
    }
}
