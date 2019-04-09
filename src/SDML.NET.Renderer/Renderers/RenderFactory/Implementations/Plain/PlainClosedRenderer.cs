using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainClosedRenderer : IRenderer
    {
		public string Render(SdmlTag element) =>
			$"{element.ClosedTag}";
	}
}
