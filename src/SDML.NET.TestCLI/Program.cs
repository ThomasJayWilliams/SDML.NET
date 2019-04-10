using System;
using SDML.NET.Core.Elements;
using SDML.NET.Core.Attributes;

namespace SDML.NET.TestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var markup = GetSdml();
            Console.WriteLine(markup);
            Console.ReadLine();
        }

        public static string GetSdml()
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
            sdmlGen.Save("C:/testExport.sdml");

            return sdmlGen.Tree.Root.Data;
        }
    }
}
