using System.Collections.Generic;

namespace SDML.NET.Core.Infrastructure.Abstractions
{
    public interface ISDMLDataElement : ISDMLObject
	{
        List<ISDMLAttribute> Attributes { get; }
        List<ISDMLDataElement> Childs { get; }
        ISDMLDataElement Parent { get; set; }
	}
}
