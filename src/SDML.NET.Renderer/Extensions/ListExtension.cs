using System.Collections.Generic;

namespace SDML.NET.Renderer.Extensions
{
    public static class ListExtension
    {
        public static string GetAll(this List<string> list)
        {
            var result = string.Empty;

            foreach (var item in list)
                result += item;

            return result;
        }
    }
}
