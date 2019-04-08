using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer.Factory
{
	internal class EscapedValueRenderer : IRenderer
    {
		public string Render(SDMLTag element) =>
			$"{element.Tabs}{element.OpenTag}{Constants.EscapeNewLineChar}" +
				$"{element.Tabs}{Constants.EscapeTabChar}{element.Object.Value}{Constants.EscapeNewLineChar}" +
				$"{element.Tabs}{element.ClosedTag}{Constants.EscapeNewLineChar}";
    }
}
