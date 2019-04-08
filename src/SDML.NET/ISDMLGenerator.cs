using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Renderer.DataStructures;

namespace SDML.NET
{
    public interface ISDMLGenerator
    {
        ElementTree Tree { get; set; }

        void Save(string path);
        void SaveAsync(string path);
        void Serialize();
        void SerializeAsync();
        void Build(ISDMLDataElement sourceElement);
        string GetData();
    }
}
