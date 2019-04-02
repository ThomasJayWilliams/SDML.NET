using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Renderer.VisualComponents
{
    public abstract class SDMLBaseVisualComponent
    {
        public string Data { get; set; }
        public ISDMLObject Source { get; set; }

        public SDMLBaseVisualComponent(ISDMLObject source)
        {
            Source = source;
        }

        public abstract void Parse();
    }
}
