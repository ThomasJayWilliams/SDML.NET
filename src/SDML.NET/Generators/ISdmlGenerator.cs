﻿using SDML.NET.Core;
using SDML.NET.Renderer;
using System.Threading.Tasks;

namespace SDML.NET
{
	// Represents main API of Sdml.NET - generate and parse data
	internal interface ISdmlGenerator
	{
		// Irrational tree of serialized elements
		ElementTree Tree { get; set; }
		// Parses data from into string data
		void Serialize();
		void SerializeAsync();
		// Builds tree from source data
		void Build(ISdmlDataElement sourceElement);
		// Returns whole document as a string
		string GetData();
    }
}
