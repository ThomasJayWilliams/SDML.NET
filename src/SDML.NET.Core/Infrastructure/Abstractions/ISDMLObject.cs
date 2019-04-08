namespace SDML.NET.Core.Infrastructure.Abstractions
{
	// Base object of all SDML... suddenly objects
    public interface ISDMLObject
	{
		// SDML object name. For tag <Solution> ObjectName will be "Solution"
		// For attribute "Name" it will be "Name"
        string ObjectName { get; }
		// Value of tag, comment or attribute
		string Value { get; set; }
	}
}
