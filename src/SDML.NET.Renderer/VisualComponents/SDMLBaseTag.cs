using SDML.NET.Renderer.DTOs;

namespace SDML.NET.Renderer.VisualComponents
{
    public abstract class SDMLBaseTag
	{
		public string Data { get; set; }
		public DataElementDTO Element { get; }

		public SDMLBaseTag(DataElementDTO data)
		{
			Element = data;
		}

        public abstract void Parse();

        public override string ToString() => Data;
    }
}
