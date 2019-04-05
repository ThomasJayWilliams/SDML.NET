namespace SDML.NET.Renderer.DTOs
{
	public class DataAttributeDTO
	{
		public string ObjectName { get; set; }
		public string Value { get; set; }
        public DataElementDTO Owner { get; set; }
	}
}
