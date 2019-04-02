using System;
using System.Collections.Generic;
using System.Text;
using SDML.NET.Core.Builders;
using SDML.NET.Core.Exceptions;
using SDML.NET.Core.Infrastructure.Models.Attributes;
using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Structures;
using SDML.NET.Core.Infrastructure.Abstractions;
using Ninject;
using Ninject.Modules;
using Ninject.Activation;
using System.Threading;

namespace SDML.NET
{
    public class DIManager : NinjectModule
    {
        public ISDMLBuilder GetBuilder() => Kernel.Get<ISDMLBuilder>();

        public override void Load()
        {
            LoadDataElements();
            LoadAttributes();
            Bind<ISDMLBuilder>().To<SDMLBuilder>();
            Bind<ISDMLComment>().To<SDMLComment>();
            Bind<ISDMLValue>().To<SDMLValue>();
            Bind<ISDMLTree<ISDMLDataElement>>().To<SDMLTree>();
            Bind<ISDMLNode<ISDMLDataElement>>().To<SDMLNode>();
        }

        private void LoadAttributes()
        {
            Bind<ISDMLNameAttribute>().To<SDMLNameAttribute>();
            Bind<ISDMLTypeAttribute>().To<SDMLTypeAttribute>();
            // Bind<ISDMLAccessAttribute>().To<SDMLAccessAttribute>();
        }

        private void LoadDataElements()
        {
            Bind<ISDMLClass>().To<SDMLClass>();
            Bind<ISDMLConstructor>().To<SDMLConstructor>();
            Bind<ISDMLDelegate>().To<SDMLDelegate>();
            Bind<ISDMLDependencies>().To<SDMLDependencies>();
            Bind<ISDMLDependency>().To<SDMLDependency>();
            Bind<ISDMLDescription>().To<SDMLDescription>();
            Bind<ISDMLDestructor>().To<SDMLDestructor>();
            Bind<ISDMLDirectory>().To<SDMLDirectory>();
            Bind<ISDMLDocument>().To<SDMLDocument>();
            Bind<ISDMLEnum>().To<SDMLEnum>();
            Bind<ISDMLField>().To<SDMLField>();
            Bind<ISDMLFile>().To<SDMLFile>();
            Bind<ISDMLInterface>().To<SDMLInterface>();
            Bind<ISDMLLibraries>().To<SDMLLibraries>();
            Bind<ISDMLLibrary>().To<SDMLLibrary>();
            Bind<ISDMLMethod>().To<SDMLMethod>();
            Bind<ISDMLNamespace>().To<SDMLNamespace>();
            Bind<ISDMLNamespaces>().To<SDMLNamespaces>();
            Bind<ISDMLParameter>().To<SDMLParameter>();
            Bind<ISDMLParameters>().To<SDMLParameters>();
            Bind<ISDMLParent>().To<SDMLParent>();
            Bind<ISDMLParents>().To<SDMLParents>();
            Bind<ISDMLProject>().To<SDMLProject>();
            Bind<ISDMLProjectStructure>().To<SDMLProjectStructure>();
            Bind<ISDMLProperty>().To<SDMLProperty>();
            Bind<ISDMLReference>().To<SDMLReference>();
            Bind<ISDMLReferences>().To<SDMLReferences>();
            Bind<ISDMLSolution>().To<SDMLSolution>();
            Bind<ISDMLSolutionStructure>().To<SDMLSolutionStructure>();
            Bind<ISDMLStruct>().To<SDMLStruct>();
        }
    }
}
