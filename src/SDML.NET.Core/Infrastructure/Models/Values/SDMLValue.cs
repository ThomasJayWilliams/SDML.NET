using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLValue : ISDMLValue
    {
        public ISDMLObject Owner { get; }
        public string Data { get; set; }
    }
}
