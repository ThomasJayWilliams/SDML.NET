using SDML.NET.Renderer.Extensions;
using SDML.NET.Renderer.Factory;
using SDML.NET.Renderer.VisualComponents;
using System;
using System.Collections.Generic;

namespace SDML.NET.Renderer
{
	// Contains data, that needed on every step of parsing
    public sealed class RenderAccumulator
    {
		// List of tabulations
		// Number of tabs caused by level of hierarchy. Every level down will get one more tab
        public List<string> Tabs { get; set; } = new List<string>();
    }

	// Heart of renderer - manages renderers and it's processes
	internal static class RenderManager
    {
		private static readonly IRendererFactory escapedFactory = new EscapedRendererFactory();
		private static readonly IRendererFactory plainFactory = new PlainRendererFactory();

		internal static void AddTab(RenderAccumulator acc) => acc.Tabs.Add(Constants.EscapeTabChar);
        internal static void RemoveTab(RenderAccumulator acc) => acc.Tabs.Remove(Constants.EscapeTabChar);

		// Depending on what needs to be rendered returns concrete renderer
        private static IRenderer GetRenderer(IRendererFactory factory, RenderOptions options)
        {
            if (options.TargetType == RenderTargetTypes.BodylessTag)
                return factory.CreateBodylessRenderer();
            else if (options.TargetType == RenderTargetTypes.ClosedTag)
                return factory.CreateClosedRenderer();
            else if (options.TargetType == RenderTargetTypes.OpenTag)
                return factory.CreateOpenRenderer();
            else if (options.TargetType == RenderTargetTypes.Value)
                return factory.CreateValueRenderer();
            else
                throw new ArgumentException("Render options are invalid!");
        }

        internal static string Render(SDMLTag element, RenderOptions options, RenderAccumulator acc)
        {
			IRenderer renderer;

			if (options.RenderType == RenderTypes.Escaped)
				renderer = GetRenderer(escapedFactory, options);

			else
				renderer = GetRenderer(plainFactory, options);

			element.Tabs = acc.Tabs.GetAll();

            if (renderer != null)
                return renderer.Render(element);

            else
                throw new NullReferenceException("Renderer is null!");
        }
    }
}
