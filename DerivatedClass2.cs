using System;
using System.Collections.Generic;
using System.Text;

namespace InheritageApp
{
    class DerivatedClass2 : BaseClass
    {
        string _name { get; }

        public DerivatedClass2(int age, string name) : base(age)
        {
            _name = name;
        }

        public new void ViewMethod()
        {
            Console.WriteLine("Name: {0}, Age: {1}.", _name, _age);
        }
    }
}
