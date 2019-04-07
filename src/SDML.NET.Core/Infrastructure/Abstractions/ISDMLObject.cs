namespace SDML.NET.Core.Infrastructure.Abstractions
{
    public interface ISDMLObject
	{
        string ObjectName { get; }
		string Value { get; set; }
	}
}
