using SDML.NET.Renderer.DTOs;
using SDML.NET.Renderer.VisualComponents;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDML.NET.Renderer.Formatters
{
	public static class Formatter
    {
        public static string FormatData(DataElementDTO data) => Build(data).ToString();        
        public static async Task FormatDataAsync(DataElementDTO data) => await Task.Run(() => Build(data).ToString());

        private static StringBuilder Build(DataElementDTO data)
        {
            var sb = new StringBuilder();

            if (data.Childs.Any() || !string.IsNullOrEmpty(data.Value))
            {
                var tag = new SDMLBodyTag(data);

                sb.AppendLine(tag.OpenTag);

                if (data.Childs.Any())
                    foreach (var item in data.Childs)
                        sb.Append(Build(item).ToString());
                else
                    sb.AppendLine(data.Value);

                sb.AppendLine(tag.CloseTag);
            }
            else
            {
                var tag = new SDMLBodylessTag(data);
                sb.AppendLine(tag.Tag);
            }

            return sb;
        }
    }
}
