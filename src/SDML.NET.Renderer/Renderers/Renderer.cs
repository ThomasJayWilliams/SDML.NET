using SDML.NET.Renderer.VisualComponents;

namespace SDML.NET.Renderer
{
    // Will contain data, required for Builder due to recusrion used in it
    public sealed class RenderAccumulator
    {
        // Represents amount of layers, used to render tabs
        public int LayerCounter { get; set; }
    }

    internal static class Renderer
    {
        internal static string RenderValue(string value, SDMLBodyTag element, RenderOptions options, RenderAccumulator acc)
        {
            var result = "";

            if (options.RenderType == RenderTypes.Plain)
            {
                result += $"{element.OpenTag}{value}{element.CloseTag}";
            }

            else if (options.RenderType == RenderTypes.Escaped)
            {
                var tabs = "";

                if (acc != null)
                    for (int i = 0; i < acc.LayerCounter; i++)
                        tabs += Constants.EscapeTabChar;

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
                var tabs = "";

                if (acc != null)
                    for (int i = 0; i < acc.LayerCounter; i++)
                        tabs += Constants.EscapeTabChar;

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
                var tabs = "";

                if (acc != null)
                    for (int i = 0; i < acc.LayerCounter; i++)
                        tabs += Constants.EscapeTabChar;

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
                var tabs = "";

                if (acc != null)
                    for (int i = 0; i < acc.LayerCounter; i++)
                        tabs += Constants.EscapeTabChar;

                result += $"{tabs}{element.CloseTag}{Constants.EscapeNewLineChar}";
            }

            return result;
        }
    }
}
