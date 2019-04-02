namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SDMLLocationAttribute : SDMLBaseAttribute
    {
        public override string ObjectName { get; } = "Location";

        public SDMLLocationAttribute(string value) : base(value) { }
    }
}
