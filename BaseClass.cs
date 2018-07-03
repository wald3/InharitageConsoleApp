using System;
using System.Collections.Generic;
using System.Text;

namespace InheritageApp
{
    class BaseClass
    {
        protected int _age { get; }

        public BaseClass(int age)
        {
            _age = age;
        }

        public virtual void ViewMethod()
        {
            Console.WriteLine("Age: {0}.", _age);
        }
    }
}
