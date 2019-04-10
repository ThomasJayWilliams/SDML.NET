using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainValueRenderer : IRenderer
    {
		public string Render(SdmlTag element) =>
			$"{element.OpenTag}{element.Object.Value}{element.ClosedTag}";
    }
}
