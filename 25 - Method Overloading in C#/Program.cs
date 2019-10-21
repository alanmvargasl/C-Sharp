using System;

namespace _25___Method_Overloading_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static void Add(int FN, int SN)
        {
            Console.WriteLine("This is my method");
        }
//It is possible to create Methods with the same name
//This is called Method Overloading, but it must have
//Different Properties , or else it will give us an error.
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("This is my method");
        }
    }
}
