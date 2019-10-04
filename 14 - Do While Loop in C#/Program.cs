using System;

namespace _14___Do_While_Loop_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            int value = int.Parse(Console.ReadLine());
            do{
                Console.WriteLine("I will do this once and then i will verify if i keep looping or not!");
            }while(value == 1);
        }
    }
}
