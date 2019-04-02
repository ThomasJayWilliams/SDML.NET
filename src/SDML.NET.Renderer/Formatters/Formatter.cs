using SDML.NET.Core.Infrastructure.Abstractions;
using System.Threading.Tasks;
using System.Text;

namespace SDML.NET.Renderer.Formatters
{
    public static class Formatter
    {
        public static string FormatData(ISDMLDataElement data)
        {
            var sb = new StringBuilder();



            return sb.ToString();
        }

        public static Task FormatDataAsync(ISDMLDataElement data)
        {
            var sb = new StringBuilder();



            return Task.Run(() => sb.ToString());
        }
    }
}
