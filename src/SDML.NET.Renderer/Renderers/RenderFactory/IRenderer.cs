using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal interface IRenderer
    {
        string Render(SDMLBaseTag element, RenderAccumulator accumulator);
    }
}
