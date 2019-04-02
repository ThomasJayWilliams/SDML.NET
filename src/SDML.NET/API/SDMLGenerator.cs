using System;
using System.Collections.Generic;
using System.Text;
using SDML.NET.Core.Builders;
using SDML.NET.Core.Exceptions;
using SDML.NET.Core.Infrastructure.Models.Attributes;
using SDML.NET.Core.Infrastructure.Models.Documents;
using SDML.NET.Core.Structures;
using SDML.NET.Core.Infrastructure.Abstractions;
using Ninject;
using Ninject.Modules;
using Ninject.Activation;
using System.Threading;

namespace SDML.NET.API
{
    public class SDMLGenerator : NinjectModule
    {
        private ISDMLBuilder builder;

        public void Initialize(ISDMLObject root)
        {

        }

        public override void Load()
        {
            
        }
    }
}
