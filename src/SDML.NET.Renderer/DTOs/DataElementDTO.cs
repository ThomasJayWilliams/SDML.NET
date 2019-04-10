using System.Collections.Generic;

namespace SDML.NET.Renderer.DTOs
{
	// DTO for SDML element
	public class DataElementDTO
    {
        public IEnumerable<DataAttributeDTO> Attributes { get; set; }
        public string ObjectName { get; set; }
        public IEnumerable<DataElementDTO> Childs { get; set; }
        public DataElementDTO Parent { get; set; }
        public string Value { get; set; }
    }
}
