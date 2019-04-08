using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainValueRenderer : IRenderer
    {
		public string Render(SDMLTag element) =>
			$"{element.OpenTag}{element.Object.Value}{element.ClosedTag}";
    }
}
