using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLLibraries : ISDMLLibraries
    {
        public bool HasBody { get; }
        public string ObjectName { get; } = "Libraries";
        public string Name { get; set; }

        public void AddAttribute(ISDMLAttribute attribute)
        {
            throw new System.NotImplementedException();
        }

        public string GetTag()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString() => GetTag();
    }
}
