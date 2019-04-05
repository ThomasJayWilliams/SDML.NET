using SDML.NET.Renderer.DTOs;
using SDML.NET.Renderer.VisualComponents;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDML.NET.Renderer.Formatters
{
	public static class Formatter
    {
        public static string FormatData(DataElementDTO data)
        {
            var sb = new StringBuilder();

            if (data.Childs.Any() || !string.IsNullOrEmpty(data.Value))
            {
                var tag = new SDMLBodyTag(data);
                tag.Parse();

                sb.AppendLine(tag.OpenTag);

                if (data.Childs.Any())
                    foreach (var item in data.Childs)
                        sb.AppendLine($"\t{FormatData(item)}");
                else
                    sb.AppendLine(data.Value);

                sb.AppendLine(tag.CloseTag);
            }
            else
            {
                var tag = new SDMLBodylessTag(data);
                tag.Parse();

                sb.AppendLine(tag.Tag);
            }

            return sb.ToString();
        }

        public static async Task FormatDataAsync(DataElementDTO data) => await Task.Run(() => FormatData(data));
    }
}
