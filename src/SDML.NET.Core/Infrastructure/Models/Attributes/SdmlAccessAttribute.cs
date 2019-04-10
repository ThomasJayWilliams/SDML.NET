namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SdmlccessAttribute : SdmlBaseAttribute
    {
        public override string ObjectName { get; } = "Access";

        public SdmlAccessAttribute(string value) : base(value) { }
    }
}
