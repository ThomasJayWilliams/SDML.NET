using System.Threading.Tasks;
using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET
{
    public class SDMLGenerator : ISDMLGenerator
    {
        public void Build(ISDMLDataElement sourceElement)
        {

        }

        public string Format()
        {
            throw new System.NotImplementedException();
        }

        public Task FormatAsync()
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
