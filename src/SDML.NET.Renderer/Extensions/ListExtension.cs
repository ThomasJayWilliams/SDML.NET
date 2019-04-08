using System.Collections.Generic;

namespace SDML.NET.Renderer.Extensions
{
    public static class ListExtension
    {
		// Allows get all elements as united string
        public static string GetAll(this List<string> list)
        {
            var result = string.Empty;

            foreach (var item in list)
                result += item;

            return result;
        }
    }
}
