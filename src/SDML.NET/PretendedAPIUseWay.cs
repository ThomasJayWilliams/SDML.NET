using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Infrastructure.Models.Attributes;
using System;

namespace SDML.NET
{
    public class PretendedAPIUseWay
    {
        public void GetSDML()
        {
            var sdmlGen = new SDMLGenerator();
            sdmlGen.Build(new SDMLDocument("SDML.NET Library Description",
                new SDMLSolution("SDML.NET",
                    new SDMLTypeAttribute(".NET Standard Library"),
                    new SDMLProject("SDML.NET",
                        new SDMLClass("InvalidNodeException",
                            new SDMLMethod(
                                new SDMLNameAttribute("ThisMethodDoesNotEvenExist")))))));

            Console.WriteLine(sdmlGen.Format());
            Console.ReadLine();
        }
    }
}
