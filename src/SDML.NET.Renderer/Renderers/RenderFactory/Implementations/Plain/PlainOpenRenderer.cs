using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainOpenRenderer : IRenderer
    {
		public string Render(SdmlTag element) =>
			$"{element.OpenTag}";
	}
}
