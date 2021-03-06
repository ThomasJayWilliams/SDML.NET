﻿namespace SDML.NET.Core.Attributes
{
	// Class represents the ContentType Attribute
	public class SdmlContentTypeAttribute : SdmlBaseAttribute
	{
		public override string ObjectName { get; } = "ContentType";

		public SdmlContentTypeAttribute(string value) : base(value) { }
	}
}
