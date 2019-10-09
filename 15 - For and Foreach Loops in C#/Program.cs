using System;

namespace _15___For_and_Foreach_Loops_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("1 -  Even Numbers \n 2 -  Odd Numbers");
        
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {   
            case 1:
                int number = 20;
                for (int i=0;i<number;i = i + 2)
                {
                    Console.WriteLine("Even Numbers " + i);
                }
                break;
            case 2: 
                int number1 =20;
                for (int i=1;i<number1;i = i +2)
                {
                    Console.WriteLine("Odd Numbers "+ i);
                }
                break;
            default: Console.WriteLine("Invalid Option");
            break;
        }
        }
    }
}
