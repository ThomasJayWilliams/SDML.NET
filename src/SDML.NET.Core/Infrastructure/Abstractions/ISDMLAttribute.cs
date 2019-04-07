namespace SDML.NET.Core.Infrastructure.Abstractions
{
	public interface ISDMLAttribute : ISDMLObject
	{
        ISDMLDataElement Owner { get; set; }
	}
}
