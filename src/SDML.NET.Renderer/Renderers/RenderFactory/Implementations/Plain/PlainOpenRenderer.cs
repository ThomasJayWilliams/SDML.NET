using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainOpenRenderer : IRenderer
    {
		public string Render(SDMLTag element) =>
			$"{element.OpenTag}";
	}
}
