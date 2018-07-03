using System;

namespace InheritageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivateClass dC = new DerivateClass(25, "ExampleName");      
            dC.ViewMethod();

            Console.ReadKey();
        }
    }
}
