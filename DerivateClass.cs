using System;
using System.Collections.Generic;
using System.Text;

namespace InheritageApp
{
    class DerivateClass : BaseClass
    {
        string _name { get; }

        public DerivateClass(int age, string name) : base(age)
        {
            _name = name;
        }

        public override void ViewMethod()
        {
            Console.WriteLine("Name: {0}, Age: {1}.", _name, _age);
        }
    }
}
