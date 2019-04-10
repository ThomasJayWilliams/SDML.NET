namespace SDML.NET.Core.Infrastructure.Abstractions
{
	// Represents SdmlAttribute
	public interface ISdmlAttribute : ISdmlObject
	{
		// Element, that contains current attribute
        ISdmlDataElement Owner { get; set; }
	}
}
