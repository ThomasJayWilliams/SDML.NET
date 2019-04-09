﻿namespace SDML.NET.Core.Infrastructure.Models.Attributes
{
		//Class to mark the IsAbstract Value
	public class SDMLIsAbstractAttribute : SDMLBaseAttribute
	{
		public override string ObjectName { get; } = "IsAbstract";

		public SDMLIsAbstractAttribute(string value) : base(value) { }
	}
}
