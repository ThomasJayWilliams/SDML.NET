using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Helpers;
using SDML.NET.Renderer;
using SDML.NET.Renderer.DataStructures;

namespace SDML.NET
{
    public class SDMLGenerator : ISDMLGenerator
    {
        private ISDMLDataElement document { get; set; }

        public ElementTree Tree { get; set; }

        public void Build(ISDMLDataElement sourceElement)
        {
            document = sourceElement;
        }

        public void Serialize() =>
            Tree = Serializer.SerializeData(SDMLGeneratorHelper.ToDTO(document), new RenderOptions());

        public void Serialize(RenderOptions options) =>
            Tree = Serializer.SerializeData(SDMLGeneratorHelper.ToDTO(document), options);

        public async void SerializeAsync() =>
            Tree = await Serializer.SerializeDataAsync(SDMLGeneratorHelper.ToDTO(document), new RenderOptions());

        public async void SerializeAsync(RenderOptions options) =>
            Tree = await Serializer.SerializeDataAsync(SDMLGeneratorHelper.ToDTO(document), options);

        public void Save(string path)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAsync(string path)
        {
            throw new System.NotImplementedException();
        }

        public string GetData() =>
            Serializer.GetData(Tree);
    }
}
