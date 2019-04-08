using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class EscapedClosedRenderer : IRenderer
    {
        public string Render(SDMLTag element) =>
			$"{element.Tabs}{element.ClosedTag}{Constants.EscapeNewLineChar}";
	}
}
