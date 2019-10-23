using System;

namespace _32___Abstract_Classes_in_C_
{
    public abstract class Customer
    {
        public abstract void Print();
    }

    class Program : Customer
    {

        public override void Print()
        {
            Console.WriteLine("This is the implementation for the Abstract inherited method");
        }

        static void Main(string[] args)
        {
            Customer C1 = new Program();
            C1.Print();
        }
    }
}
