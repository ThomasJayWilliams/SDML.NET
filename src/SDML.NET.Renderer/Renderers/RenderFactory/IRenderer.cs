using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal interface IRenderer
    {
        string Render(SdmlTag element);
    }
}
