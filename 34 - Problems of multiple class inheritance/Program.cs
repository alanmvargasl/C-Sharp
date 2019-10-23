using System;

namespace _34___Problems_of_multiple_class_inheritance
{

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }

    }
    class B : A
    {
        public override void Print()
        {
        Console.WriteLine("B Implementation");
        }
    }

    class C : A
    {
        public override void Print()
        {
        Console.WriteLine("C Implementation");
        }
    }

    class D : B
    {
        public override void Print()
        {
        Console.WriteLine("D Implementation");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
/*What this video explains is that when we have 
a class that inherits from other classes it can
get a bit confusing to know if it will override or 
use the methods on those father classes.*/