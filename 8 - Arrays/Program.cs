using System;

namespace _8___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How manny spaces do you want for the array?");
            int arraySpace = int.Parse(Console.ReadLine());
            int[] evenNumbers = new int[arraySpace];
            int counter=2;
            for (int i=0; i<arraySpace;i++)
            {
                evenNumbers[i] = counter;
                Console.WriteLine(evenNumbers[i]);
                counter = counter + 2;
            } 
            Console.WriteLine(evenNumbers.Length);
        }
    }
}
