using SDML.NET.Renderer.DTOs;
using System;
using System.Text;

namespace SDML.NET.Renderer.VisualComponents
{
    public sealed class SdmlTag
	{
		public DataElementDTO Object { get; }

		public string Tag
		{
			get { return ParseBodyless(); }
		}

		public string OpenTag
		{
			get { return ParseOpen(); }
		}

		public string ClosedTag
		{
			get { return ParseClosed(); }
		}

		public string Tabs { get; set; }

		public SdmlTag(DataElementDTO data)
		{
			Object = data;
		}

		private string ParseBodyless()
		{
			if (Object != null)
			{
				var tag = new StringBuilder();
				var attributes = new StringBuilder();

				foreach (var attr in Object.Attributes)
					attributes.Append($" {attr.ObjectName}=\"{attr.Value}\"");

				// <Solution />
				tag.Append($"{Constants.BodylessTagBeginSymbol}{Object.ObjectName}");
				tag.Append(attributes);
				tag.Append($" {Constants.BodylessTagEndSymbol}");

				return tag.ToString();
			}

			else
				throw new NullReferenceException("Object is null!");
		}

		private string ParseOpen()
		{
			if (Object != null)
			{
				var tag = new StringBuilder();
				var attributes = new StringBuilder();

				foreach (var attr in Object.Attributes)
					attributes.Append($" {attr.ObjectName}=\"{attr.Value}\"");

				// <Solution>...
				tag.Append($"{Constants.BodyOpenTagBeginSymbol}{Object.ObjectName}");
				tag.Append(attributes);
				tag.Append($"{Constants.BodyOpenTagEndSymbol}");

				return tag.ToString();
			}

			else
				throw new NullReferenceException("Object is null!");
		}

		private string ParseClosed()
		{
			if (Object != null)
				// </Solution>
				return $"{Constants.BodyCloseTagBeginSymbol}{Object.ObjectName}{Constants.BodyCloseTagEndSymbol}";

			else
				throw new NullReferenceException("Object is null!");
		}
	}
}
