using System;
using System.Collections.Generic;
using System.Text;

namespace InheritageApp
{
    // Inherit the BaseClass
    class DerivedClass1 : BaseClass
    {
        string _name { get; }

        // Sending the "age" param to the BaseClass ctor
        public DerivedClass1(int age, string name) : base(age)
        {
            _name = name;
        }

        // Overridden ViewMethod
        public override void ViewMethod()
        {
            Console.WriteLine("Name: {0}, Age: {1}.", _name, _age);
        }
    }
}
