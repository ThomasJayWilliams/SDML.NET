using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET
{
    public interface ISDMLGenerator
    {
        void Build(ISDMLDataElement sourceElement);
    }
}
