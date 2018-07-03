using System;

namespace InheritageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bC;
            DerivatedClass1 dC1 = new DerivatedClass1 (25, "ExampleName");      
            DerivatedClass2 dC2 = new DerivatedClass2 (25, "ExampleName");

            bC = dC1;
            bC.ViewMethod();
            bC = dC2;
            bC.ViewMethod();

            Console.ReadKey();
        }
    }
}
