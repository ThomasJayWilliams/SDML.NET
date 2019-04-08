using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Renderer.DataStructures;
using SDML.NET.Renderer;

namespace SDML.NET
{
    public class SDMLAutoGenerator : ISDMLGenerator
    {
        public ElementTree Tree { get; set; }

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
            Serializer.GetData(Tree);
    }
}
