using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Infrastructure.Models.Attributes;

namespace SDML.NET
{
    public class PretendedAPIUseWay
    {
        public string GetSDML()
        {
            var sdmlGen = new SdmlGenerator();
            sdmlGen.Build(new SdmlDocument(
                new SdmlNameAttribute("SDML.NET Library Description"),
                new SdmlSolution(
                    new SdmlNameAttribute("SDML.NET"),
                    new SdmlTypeAttribute(".NET Standard Library"),
                    new SdmlProject(
                        new SdmlNameAttribute("SDML.NET"),
                        new SdmlClass(
                            new SdmlNameAttribute("InvalidNodeException"),
                            new SdmlMethod(
                                new SdmlNameAttribute("ThisMethodDoesNotEvenExist"),
                                new SdmlDescription(
                                    "This is some random method. And this is its description.",
                                    new SdmlNameAttribute("ExampleDescription"))))))));

            sdmlGen.Serialize();

            return sdmlGen.Tree.Root.Data;
        }
    }
}
