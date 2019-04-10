using SDML.NET.Core;
using SDML.NET.Renderer;
using System.Threading.Tasks;

namespace SDML.NET
{
    internal class SdmlAutoGenerator : ISdmlGenerator
    {
        public ElementTree Tree { get; set; }

        public void Build(ISdmlDataElement sourceElement)
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

        public string GetData() =>
            Serializer.GetData(Tree);

		public bool Save(string path)
		{
			throw new System.NotImplementedException();
		}

		public Task<bool> SaveAsync(string path)
		{
			throw new System.NotImplementedException();
		}
	}
}
