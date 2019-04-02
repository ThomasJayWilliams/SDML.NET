using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Structures;

namespace SDML.NET.Core.Builders
{
    public interface ISDMLBuilder
    {
        ISDMLTree<ISDMLObject> Tree { get; }

        void Initialize();
        void BuildDocument(ISDMLDocument data);
        void BuildSolution(ISDMLSolution data);
        void BuildDescription(ISDMLDescription data);
        void BuildProject(ISDMLProject data);
        void BuildFile(ISDMLFile data);
        void BuildLibraries(ISDMLLibraries data);
        void BuildStructure(ISDMLStructure data);
        void BuildDirectory(ISDMLDirectory data);
        void BuildDependencies(ISDMLDependencies data);
        void BuildDependency(ISDMLDependency data);
        void BuildProjectStructure(ISDMLProjectStructure data);
        void BuildDataObject(ISDMLDataObject data);
        void BuildMethod(ISDMLMethod data);
    }
}
