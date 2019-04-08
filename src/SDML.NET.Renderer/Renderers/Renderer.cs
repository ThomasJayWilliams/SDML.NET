﻿using SDML.NET.Renderer.Extensions;
using SDML.NET.Renderer.VisualComponents;
using System.Collections.Generic;

namespace SDML.NET.Renderer
{
    // Will contain data, required for Builder due to recusrion used in it
    public sealed class RenderAccumulator
    {
        public List<string> Tabs { get; set; } = new List<string>();
    }

    internal static class Renderer
    {
        internal static void AddTab(RenderAccumulator acc) => acc.Tabs.Add(Constants.EscapeTabChar);
        internal static void RemoveTab(RenderAccumulator acc) => acc.Tabs.Remove(Constants.EscapeTabChar);

        internal static string RenderValue(string value, SDMLBodyTag element, RenderOptions options, RenderAccumulator acc)
        {
            var result = "";

            if (options.RenderType == RenderTypes.Plain)
            {
                result += $"{element.OpenTag}{value}{element.CloseTag}";
            }

            else if (options.RenderType == RenderTypes.Escaped)
            {
                var tabs = acc.Tabs.GetAll();

                result += $"{tabs}{element.OpenTag}{Constants.EscapeNewLineChar}" +
                    $"{tabs}{Constants.EscapeTabChar}{value}{Constants.EscapeNewLineChar}" +
                    $"{tabs}{element.CloseTag}{Constants.EscapeNewLineChar}";
            }

            return result;
        }

        internal static string RenderOpen(SDMLBodyTag element, RenderOptions options, RenderAccumulator acc)
        {
            var result = "";

            if (options.RenderType == RenderTypes.Plain)
            {
                result += $"{element.OpenTag}";
            }

            else if (options.RenderType == RenderTypes.Escaped)
            {
                var tabs = acc.Tabs.GetAll();

                result += $"{tabs}{element.OpenTag}{Constants.EscapeNewLineChar}";
            }

            return result;
        }

        internal static string RenderBodyless(SDMLBodylessTag element, RenderOptions options, RenderAccumulator acc)
        {
            var result = "";

            if (options.RenderType == RenderTypes.Plain)
            {
                result += $"{element.Tag}";
            }

            else if (options.RenderType == RenderTypes.Escaped)
            {
                var tabs = acc.Tabs.GetAll();

                result += $"{tabs}{element.Tag}{Constants.EscapeNewLineChar}";
            }

            return result;
        }

        internal static string RenderClosed(SDMLBodyTag element, RenderOptions options, RenderAccumulator acc)
        {
            var result = "";

            if (options.RenderType == RenderTypes.Plain)
            {
                result += $"{element.CloseTag}";
            }

            else if (options.RenderType == RenderTypes.Escaped)
            {
                var tabs = acc.Tabs.GetAll();

                result += $"{tabs}{element.CloseTag}{Constants.EscapeNewLineChar}";
            }

            return result;
        }
    }
}