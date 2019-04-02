namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
    public class SDMLNameAttribute : SDMLBaseAttribute
    {
        public override string ObjectName { get; } = "Name";

        public SDMLNameAttribute(string value) : base(value) { }
    }
}
