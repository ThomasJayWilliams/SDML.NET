using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Infrastructure.Models.Attributes;

namespace SDML.NET
{
    public class PretendedAPIUseWay
    {
        public void GetSDML()
        {
            var sdmlGen = new SDMLGenerator();
            sdmlGen.Build(new SDMLDocument(
                new SDMLNameAttribute("SolutionDescriptionDocument"),
                new SDMLSolution(
                    new SDMLNameAttribute("SDML.NET"),
                    new SDMLTypeAttribute(".NET Standard Library"),
                    new SDMLProject(
                        new SDMLNameAttribute("SDML.NET"),
                        new SDMLClass(
                            new SDMLNameAttribute("InvalidNodeException"),
                            new SDMLMethod(
                                new SDMLNameAttribute("ThisMethodDoesNotEvenExist")))))));
        }
    }
}
