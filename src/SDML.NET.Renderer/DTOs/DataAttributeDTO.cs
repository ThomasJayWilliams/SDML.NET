namespace SDML.NET.Renderer.DTOs
{
	// DTOs allows to minimize modules dependency
	// Thanks to this DTO Sdml.NET.Renderer doesn't have to know about Sdml.NET.Core classes
	public class DataAttributeDTO
	{
		public string ObjectName { get; set; }
		public string Value { get; set; }
        public DataElementDTO Owner { get; set; }
	}
}
