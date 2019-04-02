using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLProject : ISDMLProject
    {
        public bool HasBody { get; }
        public string ObjectName { get; } = "Project";
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
