using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Structures;

namespace SDML.NET
{
    public interface ISDMLGenerator
    {
        ISDMLTree Tree { get; }
        void Build(ISDMLDataElement sourceElement);
    }
}
