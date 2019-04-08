using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainClosedRenderer : IRenderer
    {
		public string Render(SDMLTag element) =>
			$"{element.ClosedTag}";
	}
}
