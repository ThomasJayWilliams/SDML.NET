using System.Collections.Generic;
using System;

namespace SDML.NET.Core.Infrastructure.Abstractions
{
	public interface ISDMLDataElement : ISDMLObject
	{
        List<ISDMLAttribute> Attributes { get; }
        List<ISDMLDataElement> Childs { get; }
        
        string GetTag();
	}
}
