using SDML.NET.Core.Infrastructure.Models;
using SDML.NET.Core.Infrastructure.Models.Attributes;

namespace SDML.NET
{
    public class PretendedAPIUseWay
    {
        public string GetSdml()
        {
            var sdmlGen = new SdmlGenerator();
            sdmlGen.Build(new SdmlDocument(
                new SdmlNameAttribute("Sdml.NET Library Description"),
                new SdmlSolution(
                    new SdmlNameAttribute("Sdml.NET"),
                    new SdmlTypeAttribute(".NET Standard Library"),
                    new SdmlProject(
                        new SdmlNameAttribute("Sdml.NET"),
                        new SdmlClass(
                            new SdmlNameAttribute("InvalidNodeException"),
                            new SdmlMethod(
                                new SdmlNameAttribute("ThisMethodDoesNotEvenExist"),
                                new SdmlDescription(
                                    "This is some random method. And this is its description.",
                                    new SdmlNameAttribute("ExampleDescription"))))))));

            sdmlGen.Serialize();
			sdmlGen.Save("F:/testExport.sdml");

            return sdmlGen.Tree.Root.Data;
        }
    }
}
