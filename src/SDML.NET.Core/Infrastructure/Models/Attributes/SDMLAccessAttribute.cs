namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SDMLAccessAttribute : ISDMLAccessAttribute
    {
        public string Value { get; set; }
        public string ObjectName { get; } = "Access";
    }
}
