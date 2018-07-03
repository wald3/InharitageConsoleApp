using System;
using System.Collections.Generic;
using System.Text;

namespace InheritageApp
{
    class BaseClass
    {
        // "Protected" used for derivated classes
        protected int _age { get; }

        // Base ctor that ill use in Derivated class
        public BaseClass(int age)
        {
            _age = age;
        }

        // Virtual method that can be overridden in derivated classes
        public virtual void ViewMethod()
        {
            Console.WriteLine("Age: {0}.", _age);
        }
    }
}
