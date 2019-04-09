using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Infrastructure.Models.Attributes;
using System;
using System.Collections.Generic;

namespace SDML.NET.Core.Infrastructure.Models
{
    public abstract class SDMLBaseElement : ISDMLDataElement
    {
        public List<ISDMLAttribute> Attributes { get; } = new List<ISDMLAttribute>();
        public List<ISDMLDataElement> Childs { get; } = new List<ISDMLDataElement>();
        public ISDMLDataElement Parent { get; set; }
        public string Value { get; set; }

        public abstract string ObjectName { get; }

        public SDMLBaseElement() { }

        public SDMLBaseElement(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!");
            Value = value;
        }
		// This constructor allows users to insert SDML Element
        public SDMLBaseElement(string value, params ISDMLObject[] attributes) : this(attributes)
        {
            if (Childs.Count > 0)
                throw new InvalidElementDeclarationException("Invalid element formatting! Element cannot hold both childs and value!");

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty!");
            Value = value;
        }

		// This constructor allows users to insert SDML element, attributes and comments as part of one SDMLObject
        public SDMLBaseElement(params ISDMLObject[] elements)
        {
            foreach (var item in elements)
            {
                if (item.GetType().IsSubclassOf(typeof(SDMLBaseAttribute)))
                {
                    ((ISDMLAttribute)item).Owner = this;
                    Attributes.Add(((ISDMLAttribute)item));
                }
                else if (item.GetType().IsSubclassOf(typeof(SDMLBaseElement)))
                {
                    ((ISDMLDataElement)item).Parent = this;
                    Childs.Add((ISDMLDataElement)item);
                }
            }
        }
    }
}
