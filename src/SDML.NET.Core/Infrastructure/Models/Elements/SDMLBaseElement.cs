using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Infrastructure.Models.Attributes;
using System.Collections.Generic;

namespace SDML.NET.Core.Infrastructure.Models
{
    public abstract class SDMLBaseElement : ISDMLDataElement
    {
        public List<ISDMLAttribute> Attributes { get; } = new List<ISDMLAttribute>();
        public List<ISDMLDataElement> Childs { get; } = new List<ISDMLDataElement>();
        public abstract string ObjectName { get; }

        public SDMLBaseElement(params ISDMLObject[] elements)
        {
            foreach (var item in elements)
            {
                if (item.GetType().IsSubclassOf(typeof(ISDMLAttribute)))
                    Attributes.Add((ISDMLAttribute)item);
                else if (item.GetType().IsSubclassOf(typeof(ISDMLDataElement)))
                    Childs.Add((ISDMLDataElement)item);
            }
        }

        public SDMLBaseElement(string name, params ISDMLObject[] elements) : this(elements)
        {
            if (!string.IsNullOrEmpty(name))
                Attributes.Add(new SDMLNameAttribute(name));
        }

        public string GetTag()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString() => GetTag();
    }
}
