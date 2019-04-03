using SDML.NET.Renderer.DTOs;
using System.Text;
using System.Threading.Tasks;

namespace SDML.NET.Renderer.Formatters
{
	public static class Formatter
    {
        public static string FormatData(DataDTO data)
        {
            var sb = new StringBuilder();



            return sb.ToString();
        }

        public static Task FormatDataAsync(DataDTO data)
        {
            var sb = new StringBuilder();



            return Task.Run(() => sb.ToString());
        }
    }
}
