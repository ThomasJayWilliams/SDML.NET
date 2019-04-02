namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SDMLNameAttribute : ISDMLNameAttribute
    {
        public string ObjectName { get; } = "Name";
        public string Value { get; set; }
    }
}
