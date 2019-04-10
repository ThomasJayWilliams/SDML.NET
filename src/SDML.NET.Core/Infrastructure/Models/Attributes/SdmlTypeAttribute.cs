namespace SDML.NET.Core.Attributes
{
    public class SdmlTypeAttribute : SdmlBaseAttribute
    {
        public override string ObjectName { get; } = "Type";

        public SdmlTypeAttribute(string value) : base(value) { }
    }
}
