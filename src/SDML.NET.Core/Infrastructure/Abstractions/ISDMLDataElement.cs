using System.Collections.Generic;

namespace SDML.NET.Core.Infrastructure.Abstractions
{
	// Main building block os Sdml - element
	// Represents Sdml tag - <Class>, <Mathod /> etc
    public interface ISDMLDataElement : ISDMLObject
	{
        List<ISDMLAttribute> Attributes { get; }
        List<ISDMLDataElement> Childs { get; }
        ISDMLDataElement Parent { get; set; }
	}
}
