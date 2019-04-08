namespace SDML.NET.Renderer
{
    public class RenderOptions
    {
        public RenderTypes RenderType { get; set; } = RenderTypes.Escaped;
        public ContentTypes ContentType { get; set; } = ContentTypes.Plain;
    }
}
