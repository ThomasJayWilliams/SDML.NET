namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SdmlLocationAttribute : SdmlBaseAttribute
    {
        public override string ObjectName { get; } = "Location";

        public SdmlLocationAttribute(string value) : base(value) { }
    }
}
