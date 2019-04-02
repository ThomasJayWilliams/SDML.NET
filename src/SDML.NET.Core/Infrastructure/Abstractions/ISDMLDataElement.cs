namespace SDML.NET.Core.Infrastructure.Abstractions
{
	public interface ISDMLDataElement : ISDMLObject
	{
        bool HasBody { get; }
        string ElementName { get; set; }

        void AddAttribute(ISDMLAttribute attribute);
        string GetTag();
	}
}
