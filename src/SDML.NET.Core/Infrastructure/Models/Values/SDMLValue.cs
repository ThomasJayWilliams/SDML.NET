using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLValue : ISDMLValue
    {
        public string ObjectName { get; }
        public string Name { get; set; }
    }
}
