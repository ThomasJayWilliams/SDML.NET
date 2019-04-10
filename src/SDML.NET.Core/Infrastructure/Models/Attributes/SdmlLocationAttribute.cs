namespace SDML.NET.Core.Attributes
{
    public class SdmlLocationAttribute : SdmlBaseAttribute
    {
        public override string ObjectName { get; } = "Location";

        public SdmlLocationAttribute(string value) : base(value) { }
    }
}
