using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
    internal class EscapedBodylessRenderer : IRenderer
    {
        public string Render(SdmlTag element) =>
			$"{element.Tabs}{element.Tag}{Constants.EscapeNewLineChar}";
	}
}
