﻿using SDML.NET.Renderer.DTOs;
using System.Text;

namespace SDML.NET.Renderer.VisualComponents
{
    public class SDMLBodylessTag : SDMLBaseTag
	{
        public string Tag { get; private set; }

		public SDMLBodylessTag(DataElementDTO data) : base(data) { }

        protected override void Parse()
        {
            if (Element != null)
            {
                var tag = new StringBuilder();
                var attributes = new StringBuilder();

                foreach (var attr in Element.Attributes)
                    attributes.Append($" {attr.ObjectName}=\"{attr.Value}\"");

                // <Solution />
                tag.Append($"{Constants.BodylessTagBeginSymbol}{Element.ObjectName}");
                tag.Append(attributes);
                tag.Append($" {Constants.BodylessTagEndSymbol}");

                Tag = tag.ToString();
            }
        }
    }
}