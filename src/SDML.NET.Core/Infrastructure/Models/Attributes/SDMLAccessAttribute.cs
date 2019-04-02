namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SDMLAccessAttribute<T> : ISDMLAccessAttribute<T>
    {
        public T ObjectValue { get; set; }
        public string Value { get; set; }
        public string ObjectName { get; } = "Access";
    }
}
