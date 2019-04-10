using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Renderer.DataStructures;

namespace SDML.NET
{
	// Represents main API of Sdml.NET - generate and parse data
	public interface ISdmlGenerator
	{
		// Irrational tree of serialized elements
		ElementTree Tree { get; set; }

		// Saves output string into file on disk
		void Save(string path);
		void SaveAsync(string path);
		// Parses data from into string data
		void Serialize();
		void SerializeAsync();
		// Builds tree from source data
		void Build(ISdmlDataElement sourceElement);
		// Returns whole document as a string
		string GetData();
    }
}
