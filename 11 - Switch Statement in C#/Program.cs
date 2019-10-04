using System;

namespace _11___Switch_Statement_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("You Choose Option 1"); 
                break;
                case 2: Console.WriteLine("You Choose Option 2"); 
                break;
                case 3: Console.WriteLine("You Choose Option 3"); 
                break;
                case 4: Console.WriteLine("You Choose Option 4"); 
                break;
                default: 
                Console.WriteLine("You Choose a number above 4"); 
                break;
            }
        }
    }
}
