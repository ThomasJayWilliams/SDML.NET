namespace SDML.NET.Core.Comments
{
    public class SdmlComment : ISdmlComment
    {
        public string ObjectName { get; } = "//";
        public string Value { get; set; }
    }
}
