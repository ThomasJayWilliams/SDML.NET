using System;
using System.IO;
using System.Threading.Tasks;

namespace SDML.NET
{
    public class SdmlWriter : ISdmlTool
    {
        public bool Save(string path, string content)
        {
            ValidateSave(path, content);
            return SdmlExporter.Save(path, content);
        }

        public async Task<bool> SaveAsync(string path, string content)
        {
            ValidateSave(path, content);
            return await SdmlExporter.SaveAsync(path, content);
        }

        public bool Save(string path, SdmlSerializer serializer) => Save(path, serializer.Data);

        public async Task<bool> SaveAsync(string path, SdmlSerializer serializer) => await SaveAsync(path, serializer.Data);

        private void ValidateSave(string path, string content)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Path cannot be null or empty!");

            if (content == null)
                throw new ArgumentException("Content cannot be null!");

            if (File.Exists(path))
                throw new FileAlreadyExistsException("File with this path is already exists! Please, choose another name or directory!");

            if (Path.GetExtension(path) != string.Empty && Path.GetExtension(path) != ".sdml")
                throw new ArgumentException("File extension should be .sdml or empty!");
        }
    }
}
