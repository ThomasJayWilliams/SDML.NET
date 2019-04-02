namespace SDML.NET.Core.Infrastructure.Abstractions
{
	public interface ISDMLAttribute : ISDMLObject
	{
        string Value { get; set; }
	}

    public interface ISDMLAttribute<T> : ISDMLAttribute
    {
        T ObjectValue { get; set; }
    }
}
