using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Infrastructure.Models.Attributes;
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

        public SDMLBaseElement(string name, params ISDMLObject[] elements) : this(elements)
        {
            if (!string.IsNullOrEmpty(name))
                Attributes.Add(new SDMLNameAttribute(name) { Owner = this });
        }
    }
}
