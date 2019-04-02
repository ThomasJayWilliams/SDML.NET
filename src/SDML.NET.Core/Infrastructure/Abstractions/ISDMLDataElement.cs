namespace SDML.NET.Core.Infrastructure.Abstractions
{
	public interface ISDMLDataElement : ISDMLObject
	{
        bool HasBody { get; }

        void AddAttribute(ISDMLAttribute attribute);
        string GetTag();
	}
}
