namespace SDML.NET.Core.Attributes
{
    public class SdmlNameAttribute : SdmlBaseAttribute
    {
        public override string ObjectName { get; } = "Name";

        public SdmlNameAttribute(string value) : base(value) { }
    }
}
