using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SDMLComment : ISDMLComment
    {
        public string ObjectName { get; } = "//";
        public string Name { get; set; }
    }
}
