using System.Collections.Generic;

namespace SDML.NET.Core
{
	// Main building block os Sdml - element
	// Represents Sdml tag - <Class>, <Mathod /> etc
    public interface ISdmlDataElement : ISdmlObject
	{
        List<ISdmlAttribute> Attributes { get; }
        List<ISdmlDataElement> Childs { get; }
        ISdmlDataElement Parent { get; set; }
	}
}
