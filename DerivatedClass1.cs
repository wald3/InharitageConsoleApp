using System;
using System.Collections.Generic;
using System.Text;

namespace InheritageApp
{
    class DerivatedClass1 : BaseClass
    {
        string _name { get; }

        public DerivatedClass1(int age, string name) : base(age)
        {
            _name = name;
        }

        public override void ViewMethod()
        {
            Console.WriteLine("Name: {0}, Age: {1}.", _name, _age);
        }
    }
}
