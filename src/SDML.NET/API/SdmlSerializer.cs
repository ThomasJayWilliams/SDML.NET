﻿using SDML.NET.Core;
using System;

namespace SDML.NET
{
    public class SdmlSerializer : ISdmlTool
    {
        public string Data { get; private set; }

        public string Serialize(ISdmlDataElement data)
        {
            if (data == null)
                throw new ArgumentException("Data cannot be null!");

            var generator = new SdmlGenerator();
            generator.Build(data);
            generator.Serialize();

            Data = generator.GetData();

            return Data;
        }
    }
}
