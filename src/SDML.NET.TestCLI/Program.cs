using System;
using SDML.NET.Core.Elements;
using SDML.NET.Core.Attributes;

namespace SDML.NET.TestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSdml();
        }

        public static void GetSdml()
        {
            var data = new SdmlDocument(
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
                                    new SdmlNameAttribute("ExampleDescription")))))));

            var serializer = new SdmlSerializer();
            Console.WriteLine(serializer.Serialize(data));
        }
    }
}
