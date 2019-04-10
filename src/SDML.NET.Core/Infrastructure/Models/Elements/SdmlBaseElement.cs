using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Infrastructure.Models.Attributes;
using System;
using System.Collections.Generic;

namespace SDML.NET.Core.Infrastructure.Models
{
    public abstract class SdmlBaseElement : ISdmlDataElement
    {
        public List<ISdmlAttribute> Attributes { get; } = new List<ISdmlAttribute>();
        public List<ISdmlDataElement> Childs { get; } = new List<ISdmlDataElement>();
        public ISdmlDataElement Parent { get; set; }
        public string Value { get; set; }

        public abstract string ObjectName { get; }

        public SdmlBaseElement() { }

        public SdmlBaseElement(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!");
            Value = value;
        }
		// This constructor allows users to insert Sdml Element
        public SdmlBaseElement(string value, params ISdmlObject[] attributes) : this(attributes)
        {
            if (Childs.Count > 0)
                throw new InvalidElementDeclarationException("Invalid element formatting! Element cannot hold both childs and value!");

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!");
            Value = value;
        }

		// This constructor allows users to insert Sdml element, attributes and comments as part of one SdmlObject
        public SdmlBaseElement(params ISdmlObject[] elements)
        {
            foreach (var item in elements)
            {
                if (item.GetType().IsSubclassOf(typeof(SdmlBaseAttribute)))
                {
                    ((ISdmlAttribute)item).Owner = this;
                    Attributes.Add(((ISdmlAttribute)item));
                }
                else if (item.GetType().IsSubclassOf(typeof(SdmlBaseElement)))
                {
                    ((ISdmlDataElement)item).Parent = this;
                    Childs.Add((ISdmlDataElement)item);
                }
            }
        }
    }
}
