using System;

namespace InheritageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //obj of DerivatedClass1, that HAS overridden ViewMethod
            DerivedClass1 dC1 = new DerivedClass1 (25, "ExampleName");
            //obj of DerivatedClass2, that DIDN'T HAS overridden ViewMethod
            DerivedClass2 dC2 = new DerivedClass2 (50, "ExampleName");

            //link to the base class
            BaseClass bCRef;

            bCRef = dC1;
            bCRef.ViewMethod(); // Name: ExampleName, Age: 25.

            bCRef = dC2; 
            bCRef.ViewMethod(); // Age: 50.

            Console.ReadKey();
        }
    }
}
