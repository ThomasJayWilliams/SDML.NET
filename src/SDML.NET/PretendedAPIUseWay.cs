using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Infrastructure.Models.Attributes;

namespace SDML.NET
{
    public class PretendedAPIUseWay
    {
        public string GetSDML()
        {
            var sdmlGen = new SDMLGenerator();
            sdmlGen.Build(new SDMLDocument(
                new SDMLNameAttribute("SDML.NET Library Description"),
                new SDMLSolution(
                    new SDMLNameAttribute("SDML.NET"),
                    new SDMLTypeAttribute(".NET Standard Library"),
                    new SDMLProject(
                        new SDMLNameAttribute("SDML.NET"),
                        new SDMLClass(
                            new SDMLNameAttribute("InvalidNodeException"),
                            new SDMLMethod(
                                new SDMLNameAttribute("ThisMethodDoesNotEvenExist"),
                                new SDMLDescription(
                                    "This is some random method. And this is its description.",
                                    new SDMLNameAttribute("ExampleDescription"))))))));

            sdmlGen.Serialize();

            return sdmlGen.Tree.Root.Data;
        }
    }
}
