namespace SDML.NET.Renderer
{
	// Represents render types of tags
    public enum RenderTypes
    {
		// Escaped parsing provides visual components like \t, \n etc.
        Escaped = 0,
		// Plain parsing. The result will look like clear string without spaces and tabs
        Plain
    }
}
