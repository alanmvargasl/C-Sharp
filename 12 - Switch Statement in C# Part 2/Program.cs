using System;

namespace _12___Switch_Statement_in_C__Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeeCost =0;
            Console.WriteLine("1 - Small , 2 - Medium  , 3 - Large ");
            int usersChoice = int.Parse(Console.ReadLine());
            switch (usersChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;
                case 3:
                    totalCoffeeCost += 3;
                    break;
                default: 
                Console.WriteLine("Your Choice {0} is invalid", usersChoice);
                break;
                
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", totalCoffeeCost);
        }
    }
}
