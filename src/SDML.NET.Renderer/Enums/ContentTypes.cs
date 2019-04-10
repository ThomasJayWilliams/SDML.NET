namespace SDML.NET.Renderer
{
	// Represents different types of value content of element
	// Saying "value" means tag value i.e. - <Desciption>Value</Description>
    public enum ContentTypes
    {
		// Plain text without any markup
        Plain = 0,
        HTML,
        JSON,
        XML
    }
}
