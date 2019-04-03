using SDML.NET.Renderer.DTOs;
using System.Collections.Generic;

namespace SDML.NET.Renderer.VisualComponents
{
	public abstract class SDMLBaseTag
	{
		public string Data { get; set; }
		public IEnumerable<DataAttributeDTO> Attributes { get; }
		public DataElementDTO Element { get; }

		public SDMLBaseTag(IEnumerable<DataAttributeDTO> attributes, DataElementDTO element)
		{
			Attributes = attributes;
			Element = element;
		}

        public abstract void Parse();

        public override string ToString() => Data;
    }
}
