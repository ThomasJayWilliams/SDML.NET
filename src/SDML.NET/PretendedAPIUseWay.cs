using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Infrastructure.Models.Attributes;

namespace SDML.NET
{
    public class PretendedAPIUseWay
    {
        public void GetSDML()
        {
            var sdmlGen = new SDMLGenerator();
            sdmlGen.Build(new SDMLSolution(
                new SDMLProject(
                    new SDMLNameAttribute(""),
                    new SDMLClass("SDMLBuilder",
                        new SDMLMethod("Initialize"),
                        new SDMLMethod("BuildLibrary")),
                    new SDMLClass("SDMLSubBuilder")),
                new SDMLNameAttribute("SDML.NET"),
                new SDMLTypeAttribute(".NET Standard Library")));
        }
    }
}
