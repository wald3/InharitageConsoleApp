using System;
using System.Collections.Generic;
using System.Text;

namespace InheritageApp
{
    //inherit the BaseClass
    class DerivedClass2 : BaseClass
    {
        string _name { get; }

        //sending the "age" param to the BaseClass ctor
        public DerivedClass2(int age, string name) : base(age)
        {
            _name = name;
        }

        //not overridden ViewMetod, it's NEW
        public new void ViewMethod()
        {
            Console.WriteLine("Name: {0}, Age: {1}.", _name, _age);
        }
    }
}
