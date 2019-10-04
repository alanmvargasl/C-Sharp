using System;

namespace _13___While_Loop_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            int number = int.Parse(Console.ReadLine());
            int i =0;
            while (number == 20)
            {
                i++;
                Console.WriteLine("This is lap" + i);
                if (i==100){ number =21;}
            }
            Console.WriteLine(i);
        }
    }
}
