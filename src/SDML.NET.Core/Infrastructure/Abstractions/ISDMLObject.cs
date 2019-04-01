using System.Collections.Generic;

namespace SDML.NET.Core.Infrastructure.Abstractions
{
	public interface ISDMLObject
	{
		ISDMLObject Parent { get; set; }
		IDictionary<string, ISDMLObject> Childs { get; set; }
		string Name { get; set; }
	}
}
