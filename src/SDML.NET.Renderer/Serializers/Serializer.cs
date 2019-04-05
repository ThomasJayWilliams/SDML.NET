using SDML.NET.Renderer.DTOs;
using SDML.NET.Renderer.VisualComponents;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDML.NET.Renderer.Formatters
{
	public static class Serializer
    {
        private static int _tabCounter = 0;

        public static string SerializeData(DataElementDTO data) => Build(data).ToString();        
        public static async Task SerializeDataAsync(DataElementDTO data) => await Task.Run(() => Build(data).ToString());

        private static StringBuilder Build(DataElementDTO data)
        {
            var sb = new StringBuilder();

            if (data.Childs.Any() || !string.IsNullOrEmpty(data.Value))
            {
                var tag = new SDMLBodyTag(data);

                sb.AppendLine(WriteTag(tag.OpenTag));

                if (data.Childs.Any())
                {
                    _tabCounter++;
                    foreach (var item in data.Childs)
                        sb.Append(Build(item).ToString());
                }
                else
                    _tabCounter++;
                    sb.AppendLine(WriteTag(data.Value));

                _tabCounter--;
                sb.Append(WriteTag(tag.CloseTag));
            }
            else
            {
                var tag = new SDMLBodylessTag(data);
                sb.AppendLine(WriteTag(tag.Tag));
            }

            return sb;
        }

        private static string WriteTag(string tagPart) => $"{GetTabs()}{tagPart}";

        private static string GetTabs()
        {
            var result = "";
            for (int i = 0; i < _tabCounter; i++)
                result += "\t";
            return result;
        }
    }
}
