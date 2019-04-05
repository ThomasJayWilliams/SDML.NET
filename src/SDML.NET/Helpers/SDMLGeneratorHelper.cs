using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Renderer.DTOs;
using System.Collections.Generic;

namespace SDML.NET.Helpers
{
    public static class SDMLGeneratorHelper
    {
        public static DataElementDTO ToDTO(ISDMLDataElement data)
        {
            var dto = new DataElementDTO();
            if (data != null)
            {
                var attributes = new List<DataAttributeDTO>();
                var childs = new List<DataElementDTO>();

                dto.ObjectName = data.ObjectName;

                foreach (var item in data.Attributes)
                    attributes.Add(ToDTO(item));

                dto.Attributes = attributes;

                foreach (var item in data.Childs)
                    childs.Add(ToDTO(item));

                dto.Parent = ToDTO(data.Parent);
            }

            return dto;
        }

        public static DataAttributeDTO ToDTO(ISDMLAttribute data) => new DataAttributeDTO() { ObjectName = data.ObjectName, Value = data.Value };
    }
}
