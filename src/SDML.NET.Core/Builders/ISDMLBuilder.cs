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
        void BuildLibrary(ISDMLLibrary data);
        void BuildStructure(ISDMLSolutionStructure data);
        void BuildDirectory(ISDMLDirectory data);
        void BuildDependencies(ISDMLDependencies data);
        void BuildDependency(ISDMLDependency data);
        void BuildProjectStructure(ISDMLProjectStructure data);
        void BuildDataObject(ISDMLClass data);
        void BuildMethod(ISDMLMethod data);
        void BuildProperty(ISDMLProperty data);
        void BuildConstructor(ISDMLConstructor data);
        void BuildParameters(ISDMLParameters data);
        void BuildParameter(ISDMLParameter data);
        void BuildParents(ISDMLParents dat);
        void BuildParent(ISDMLParent data);
        void BuildEnum(ISDMLEnum data);
        void BuildInterface(ISDMLInterface data);
        void BuildStruct(ISDMLStruct data);
        void BuildReferences(ISDMLReferences data);
        void BuildReference(ISDMLReference data);
        void BuildDelegate(ISDMLDelegate data);
        void BuildNamespaces(ISDMLNamespaces data);
        void BuildNamesapce(ISDMLNamespace data);
        void BuildField(ISDMLField data);
        void BuildDestructor(ISDMLDestructor data);
    }
}
