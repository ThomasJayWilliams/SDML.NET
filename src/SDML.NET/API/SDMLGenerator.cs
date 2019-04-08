using System.Threading.Tasks;
using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Helpers;
using SDML.NET.Renderer.DataStructures;
using SDML.NET.Renderer.Formatters;

namespace SDML.NET
{
    public class SDMLGenerator : ISDMLGenerator
    {
        private ISDMLDataElement document { get; set; }

        public ElementTree Elements { get; set; }

        public void Build(ISDMLDataElement sourceElement)
        {
            document = sourceElement;
        }

        public void Serialize() =>
            Elements = Serializer.SerializeData(SDMLGeneratorHelper.ToDTO(document));

        public async void SerializeAsync() =>
            Elements = await Serializer.SerializeDataAsync(SDMLGeneratorHelper.ToDTO(document));

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
