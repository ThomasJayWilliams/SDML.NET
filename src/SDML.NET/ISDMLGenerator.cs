using SDML.NET.Core.Infrastructure.Abstractions;
using System.Threading.Tasks;

namespace SDML.NET
{
    public interface ISDMLGenerator
    {
        void Save(string path);
        void SaveAsync(string path);
        string Serialize();
        Task SerializeAsync();
        void Build(ISDMLDataElement sourceElement);
    }
}
