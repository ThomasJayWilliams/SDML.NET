using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Helpers;
using SDML.NET.Renderer;
using SDML.NET.Renderer.DataStructures;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SDML.NET
{
    public class SDMLGenerator : ISDMLGenerator
    {
        private ISDMLDataElement document { get; set; }

        public ElementTree Tree { get; set; }

        public void Build(ISDMLDataElement sourceElement)
        {
            document = sourceElement ??
                throw new ArgumentException("Element cannot be null!");
        }

		// Serialize source data to Renderer.DTOs and then sends them to Renderer
        public void Serialize() =>
            Tree = Serializer.SerializeData(SDMLGeneratorHelper.ToDTO(document), new RenderOptions());

		// Besides data sends render options, which contains configurations for renderer
        public void Serialize(RenderOptions options) =>
            Tree = Serializer.SerializeData(SDMLGeneratorHelper.ToDTO(document), options);

        public async void SerializeAsync() =>
            Tree = await Serializer.SerializeDataAsync(SDMLGeneratorHelper.ToDTO(document), new RenderOptions());

        public async void SerializeAsync(RenderOptions options) =>
            Tree = await Serializer.SerializeDataAsync(SDMLGeneratorHelper.ToDTO(document), options);

        public bool Save(string path)
        {
			ValidateSave(path);
			return Exporters.SdmlExporter.Save(path, Tree.Root.Data);
		}

        public async Task<bool> SaveAsync(string path)
        {
			ValidateSave(path);
			return await Exporters.SdmlExporter.SaveAsync(path, Tree.Root.Data);
        }

        public string GetData() =>
            Serializer.GetData(Tree);

		private void ValidateSave(string path)
		{
			if (string.IsNullOrEmpty(path))
				throw new ArgumentException("Path cannot be null or empty!");

			if (string.IsNullOrEmpty(Tree.Root.Data))
				throw new ArgumentException("Content cannot be null or empty!");

			if (File.Exists(path))
				throw new FileAlreadyExistsException("File with this path is already exists! Please, choose another name or directory!");

			if (Path.GetExtension(path) != string.Empty && Path.GetExtension(path) != ".sdml")
				throw new ArgumentException("File extension should be .sdml or empty!");
		}
    }
}
