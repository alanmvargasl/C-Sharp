using System;

namespace _24___Difference_Between_Method_Overriding_and_Method_Hiding
{

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Print ()
        {
            Console.WriteLine("I am a Derived Class Method");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BaseClass NEWBASECLASS = new DerivedClass();
            NEWBASECLASS.Print();
        }
    }
}
