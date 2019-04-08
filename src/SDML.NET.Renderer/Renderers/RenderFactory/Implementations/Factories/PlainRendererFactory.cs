using SDML.NET.Renderer.VisualComponents;
using System;

namespace SDML.NET.Renderer.Factory
{
    internal class PlainRendererFactory : IRendererFactory
    {
		public IRenderer CreateBodylessRenderer() =>
			new PlainBodylessRenderer();

		public IRenderer CreateClosedRenderer() =>
			new PlainClosedRenderer();

		public IRenderer CreateOpenRenderer() =>
			new PlainOpenRenderer();

		public IRenderer CreateValueRenderer() =>
			new PlainValueRenderer();
    }
}
