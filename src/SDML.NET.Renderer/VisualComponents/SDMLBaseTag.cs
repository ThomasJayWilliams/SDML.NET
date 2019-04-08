using SDML.NET.Renderer.DTOs;

namespace SDML.NET.Renderer.VisualComponents
{
    public abstract class SDMLBaseTag
	{
		public DataElementDTO Object { get; }

		public SDMLBaseTag(DataElementDTO data)
		{
			Object = data;
            Parse();
		}

        protected abstract void Parse();
    }
}
