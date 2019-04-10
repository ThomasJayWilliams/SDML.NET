namespace SDML.NET.Core.Attributes
{
    public class SdmlAccessAttribute : SdmlBaseAttribute
    {
        public override string ObjectName { get; } = "Access";

        public SdmlAccessAttribute(string value) : base(value) { }
    }
}
