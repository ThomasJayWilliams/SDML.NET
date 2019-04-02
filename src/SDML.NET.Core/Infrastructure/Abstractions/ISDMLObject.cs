namespace SDML.NET.Core.Infrastructure.Abstractions
{
    public interface ISDMLObject
	{
        string ObjectName { get; }
		string Name { get; set; }
	}
}
