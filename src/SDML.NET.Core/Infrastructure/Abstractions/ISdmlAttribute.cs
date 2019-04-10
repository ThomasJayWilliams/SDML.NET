namespace SDML.NET.Core
{
	// Represents SdmlAttribute
	public interface ISdmlAttribute : ISdmlObject
	{
		// Element, that contains current attribute
        ISdmlDataElement Owner { get; set; }
	}
}
