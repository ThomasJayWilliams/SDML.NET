namespace SDML.NET.Core.Infrastructure.Abstractions
{
	public interface ISDMLValue
	{
        ISDMLObject Owner { get; }
        string Data { get; set; }
	}
}
