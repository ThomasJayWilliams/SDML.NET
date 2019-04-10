using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Helpers;
using SDML.NET.Renderer;
using SDML.NET.Renderer.DataStructures;
using System;

namespace SDML.NET
{
    public class SdmlGenerator : ISdmlGenerator
    {
        private ISdmlDataElement document { get; set; }

        public ElementTree Tree { get; set; }

        public void Build(ISdmlDataElement sourceElement)
        {
            document = sourceElement ??
                throw new ArgumentException("Element cannot be null!");
        }

		// Serialize source data to Renderer.DTOs and then sends them to Renderer
        public void Serialize() =>
            Tree = Serializer.SerializeData(SdmlGeneratorHelper.ToDTO(document), new RenderOptions());

		// Besides data sends render options, which contains configurations for renderer
        public void Serialize(RenderOptions options) =>
            Tree = Serializer.SerializeData(SdmlGeneratorHelper.ToDTO(document), options);

        public async void SerializeAsync() =>
            Tree = await Serializer.SerializeDataAsync(SdmlGeneratorHelper.ToDTO(document), new RenderOptions());

        public async void SerializeAsync(RenderOptions options) =>
            Tree = await Serializer.SerializeDataAsync(SdmlGeneratorHelper.ToDTO(document), options);

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
