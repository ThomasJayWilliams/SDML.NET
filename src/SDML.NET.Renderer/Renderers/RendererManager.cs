using SDML.NET.Renderer.Extensions;
using SDML.NET.Renderer.Factory;
using SDML.NET.Renderer.VisualComponents;
using System;
using System.Collections.Generic;

namespace SDML.NET.Renderer
{
    // Will contain data, required for Builder due to recusrion used in it
    public sealed class RenderAccumulator
    {
        public List<string> Tabs { get; set; } = new List<string>();
    }

    internal static class RendererManager
    {
        internal static void AddTab(RenderAccumulator acc) => acc.Tabs.Add(Constants.EscapeTabChar);
        internal static void RemoveTab(RenderAccumulator acc) => acc.Tabs.Remove(Constants.EscapeTabChar);

        private static IRendererFactory GetFactory(RenderOptions options)
        {
            if (options.RenderType == RenderTypes.Escaped)
                return new EscapedRendererFactory();
            else if (options.RenderType == RenderTypes.Plain)
                return new PlainRendererFactory();
            else
                throw new ArgumentException("Render options are invalid!");
        }

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
            var renderer = GetRenderer(GetFactory(options), options);
			element.Tabs = acc.Tabs.GetAll();

            if (renderer != null)
                return renderer.Render(element);

            else
                throw new NullReferenceException("Renderer is null!");
        }
    }
}
