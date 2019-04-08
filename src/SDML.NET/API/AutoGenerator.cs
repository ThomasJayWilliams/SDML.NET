using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Renderer.DataStructures;
using SDML.NET.Renderer.Formatters;

namespace SDML.NET
{
    public class AutoGenerator : ISDMLGenerator
    {
        public ElementTree Elements { get; set; }

        public void Build(ISDMLDataElement sourceElement)
        {
            
        }

        public void Serialize()
        {
            throw new System.NotImplementedException();
        }

        public void SerializeAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Save(string path)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAsync(string path)
        {
            throw new System.NotImplementedException();
        }

        public string GetData() =>
            Serializer.GetData(Elements);
    }
}
