using System;
using System.IO;

namespace SDML.NET
{
    public class SdmlReader : ISdmlTool
    {
        public string Data { get; private set; }

        public void Read(string path) => Read(path, new ImportOptions());

        public void Read(string path, ImportOptions options)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Path cannot be null or empty!");

            if (!File.Exists(path))
                throw new FileNotFoundException("File does not exist!");

            var importer = new SdmlImporter();
            Data = importer.Read(path, options);
        }

        public string GetEscaped() => GetEscaped(Data);

        // Will return escaped data woth spaces, tabs and lines
        // TODO
        public string GetEscaped(string content)
        {
            return Data;
        }
    }
}
