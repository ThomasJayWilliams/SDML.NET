namespace SDML.NET.Core.Infrastructure.Abstractions
{
	// Represents SDMLAttribute
	public interface ISDMLAttribute : ISDMLObject
	{
		// Element, that contains current attribute
        ISDMLDataElement Owner { get; set; }
	}
}
