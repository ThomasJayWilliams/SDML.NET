using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Renderer.DTOs;
using System;
using System.Collections.Generic;

namespace SDML.NET.Helpers
{
    public static class SDMLGeneratorHelper
    {
		// Converts source data to Renderer.DTO
		// To convert data uses recursion
		// Converts elements
        public static DataElementDTO ToDTO(ISDMLDataElement data)
        {
            var dto = new DataElementDTO();

            if (data != null)
            {
                var attributes = new List<DataAttributeDTO>();
                var childs = new List<DataElementDTO>();

                dto.ObjectName = data.ObjectName;

                foreach (var item in data.Attributes)
                    attributes.Add(ToDTO(item, dto));

                dto.Attributes = attributes;

                foreach (var item in data.Childs)
                {
                    var element = ToDTO(item);
                    element.Parent = dto;
                    childs.Add(element);
                }

                dto.Childs = childs;
                dto.Value = data.Value;
            }

            else
                throw new NullReferenceException("Data element is null!");

            return dto;
        }

		// Converts attributes
        public static DataAttributeDTO ToDTO(ISDMLAttribute data, DataElementDTO owner) => 
            new DataAttributeDTO() { ObjectName = data.ObjectName, Value = data.Value, Owner = owner };
    }
}
