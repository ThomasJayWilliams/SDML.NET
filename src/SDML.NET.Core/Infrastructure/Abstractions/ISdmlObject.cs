namespace SDML.NET.Core
{
	// Base object of all Sdml... suddenly objects
    public interface ISdmlObject
	{
		// Sdml object name. For tag <Solution> ObjectName will be "Solution"
		// For attribute "Name" it will be "Name"
        string ObjectName { get; }
		// Value of tag, comment or attribute
		string Value { get; set; }
	}
}
