using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainBodylessRenderer : IRenderer
    {
		public string Render(SdmlTag element) =>
			$"{element.Tag}";
	}
}
