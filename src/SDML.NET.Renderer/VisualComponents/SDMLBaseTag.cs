using SDML.NET.Renderer.DTOs;

namespace SDML.NET.Renderer.VisualComponents
{
    public abstract class SDMLBaseTag
	{
		public DataElementDTO Element { get; }

		public SDMLBaseTag(DataElementDTO data)
		{
			Element = data;
            Parse();
		}

        protected abstract void Parse();
    }
}
