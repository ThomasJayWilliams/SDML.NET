using System.Collections.Generic;

namespace SDML.NET.Renderer.DTOs
{
	public class DataDTO
	{
		public IEnumerable<DataAttributeDTO> Attributes { get; set; }
		public DataElementDTO Element { get; set; }
	}
}
