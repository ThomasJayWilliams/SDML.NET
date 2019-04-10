using System;

namespace SDML.NET.TestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new PretendedAPIUseWay();

            var markup = test.GetSdml();
            Console.WriteLine(markup);
            Console.ReadLine();
        }
    }
}
