namespace SDML.NET.Renderer
{
	// Represents notes for renderer, which allow Renderer to know how to parse elements
    public enum RenderTargetTypes
    {
		// Means element with value - <Solution>Lorem ipsum</Solution>
        Value = 0,
		// Means open part of tag - <Document>
        OpenTag,
		// Closed part of tag - </Document>
        ClosedTag,
		// Means tag without children and value - <Method />
        BodylessTag
    }
}
