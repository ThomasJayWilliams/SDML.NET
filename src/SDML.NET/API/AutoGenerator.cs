using System.Threading.Tasks;
using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET
{
    public class AutoGenerator : ISDMLGenerator
    {
        public void Build(ISDMLDataElement sourceElement)
        {
            
        }

        public string Serialize()
        {
            throw new System.NotImplementedException();
        }

        public Task SerializeAsync()
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
    }
}
