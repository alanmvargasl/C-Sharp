using System;

namespace _10___If_Statement_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("You typed number 1");
            }
            else if (number == 2)
            {
                Console.WriteLine("You typed number 2");
            }
             else if (number == 3)
            {
                Console.WriteLine("You typed number 3");
            }
             else if (number == 4)
            {
                Console.WriteLine("You typed number 4");
            }
            else 
            {
                Console.WriteLine("You typed a number above 4");
            }

        }
    }
}
