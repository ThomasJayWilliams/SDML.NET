using SDML.NET.Core.Infrastructure.Abstractions;
using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Structures;

namespace SDML.NET.Core.Builders
{
    public class SDMLBuilder : ISDMLBuilder
    {
        public ISDMLTree<ISDMLObject> Tree { get; }

        public SDMLBuilder(ISDMLTree<ISDMLObject> tree)
        {
            Tree = tree;
        }

        public void BuildDataObject(SDMLClass data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDependencies(ISDMLDependencies data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDependency(ISDMLDependency data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDescription(ISDMLDescription data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDirectory(ISDMLDirectory data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDocument(ISDMLDocument data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildFile(ISDMLFile data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildLibraries(ISDMLLibraries data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildMethod(ISDMLMethod data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildProject(ISDMLProject data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildProjectStructure(ISDMLProjectStructure data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildSolution(ISDMLSolution data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildStructure(ISDMLSolutionStructure data)
        {
            throw new System.NotImplementedException();
        }

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void BuildLibrary(ISDMLLibrary data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDataObject(ISDMLClass data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildProperty(ISDMLProperty data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildConstructor(ISDMLConstructor data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildParameters(ISDMLParameters data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildParameter(ISDMLParameter data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildParents(ISDMLParents dat)
        {
            throw new System.NotImplementedException();
        }

        public void BuildParent(ISDMLParent data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildEnum(ISDMLEnum data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildInterface(ISDMLInterface data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildStruct(ISDMLStruct data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildReferences(ISDMLReferences data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildReference(ISDMLReference data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDelegate(ISDMLDelegate data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildNamespaces(ISDMLNamespaces data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildNamesapce(ISDMLNamespace data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildField(ISDMLField data)
        {
            throw new System.NotImplementedException();
        }

        public void BuildDestructor(ISDMLDestructor data)
        {
            throw new System.NotImplementedException();
        }
    }
}
