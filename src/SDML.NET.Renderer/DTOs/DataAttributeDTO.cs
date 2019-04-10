namespace SDML.NET.Renderer.DTOs
{
	// DTOs allows to minimize modules dependency
	// Thanks to this DTO SDML.NET.Renderer doesn't have to know about SDML.NET.Core classes
	public class DataAttributeDTO
	{
		public string ObjectName { get; set; }
		public string Value { get; set; }
        public DataElementDTO Owner { get; set; }
	}
}
