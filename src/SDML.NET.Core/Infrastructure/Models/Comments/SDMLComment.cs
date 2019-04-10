using SDML.NET.Core.Infrastructure.Abstractions;

namespace SDML.NET.Core.Infrastructure.Models
{
    public class SdmlComment : ISDMLComment
    {
        public string ObjectName { get; } = "//";
        public string Value { get; set; }
    }
}
