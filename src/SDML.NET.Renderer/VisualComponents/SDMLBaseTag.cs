namespace SDML.NET.Renderer.VisualComponents
{
    public abstract class SDMLBaseTag
    {
        public string Data { get; set; }

        public abstract void Parse();

        public override string ToString() => Data;
    }
}
