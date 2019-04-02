using System;
using System.Collections.Generic;
using System.Text;
using SDML.NET.Core.Builders;
using SDML.NET.Core.Exceptions;
using SDML.NET.Core.Infrastructure.Models.Attributes;
using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Structures;
using SDML.NET.Core.Infrastructure.Abstractions;
using System.Threading;

namespace SDML.NET
{
    public class SDMLGenerator
    {
        private ISDMLBuilder builder;
        private DIManager diManage;

        public SDMLGenerator()
        {
            diManage = new DIManager();
            diManage.Load();
            builder = diManage.GetBuilder();
        }

        public void Initialize(ISDMLObject root)
        {

        }
    }
}
