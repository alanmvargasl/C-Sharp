using System;

namespace _30___Interfaces_in_C_
{
    interface ICostumer
    {
        void Print(); //You Cannot Implement Anything here
        //Just Declarations are accepted!
    }

    interface ICostumer2
    {
        void Print2(); //Same Here
    }

    class Customer : ICostumer, ICostumer2
    { //All the implementations are defined here
    //A Class Can Inherit more than one Interface
        public void Print()
        {
            Console.WriteLine("This is Interface Print Method1");
        }
        public void Print2()
        {
            Console.WriteLine("This is Interface Print Method2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print();
            C1.Print2();
        }
    }
}
