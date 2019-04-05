using System;

namespace SDML.NET.TestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new PretendedAPIUseWay();
            Console.WriteLine(test.GetSDML());
            Console.ReadKey();
        }
    }
}
