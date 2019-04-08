using System;

namespace SDML.NET.Renderer.Factory
{
	internal class EscapedRendererFactory : IRendererFactory
    {
		public IRenderer CreateBodylessRenderer() =>
			new EscapedBodylessRenderer();

		public IRenderer CreateClosedRenderer() =>
			new EscapedClosedRenderer();

		public IRenderer CreateOpenRenderer() =>
			new EscapedOpenRenderer();

		public IRenderer CreateValueRenderer() =>
			new EscapedValueRenderer();
    }
}
