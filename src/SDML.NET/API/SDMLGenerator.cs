using System.Threading.Tasks;
using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Helpers;
using SDML.NET.Renderer.Formatters;

namespace SDML.NET
{
    public class SDMLGenerator : ISDMLGenerator
    {
        public ISDMLDataElement Document { get; private set; }

        public void Build(ISDMLDataElement sourceElement)
        {
            Document = sourceElement;
        }

        public string Format() =>
            Formatter.FormatData(SDMLGeneratorHelper.ToDTO(Document));

        public async Task FormatAsync() =>
            await Formatter.FormatDataAsync(SDMLGeneratorHelper.ToDTO(Document));

        public void Save(string path)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAsync(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
