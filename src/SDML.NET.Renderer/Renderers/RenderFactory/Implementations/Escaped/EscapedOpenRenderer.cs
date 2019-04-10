using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
	internal class EscapedOpenRenderer : IRenderer
    {
		public string Render(SdmlTag element) =>
			$"{element.Tabs}{element.OpenTag}{Constants.EscapeNewLineChar}";
    }
}
