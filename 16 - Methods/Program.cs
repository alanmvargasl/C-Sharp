
using System;

namespace _16___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(addMethod(2,4));
           Console.WriteLine(substractMethod(33,43));
        }

        static int addMethod (int number1, int number2)
        {
            return number1 + number2;
        }

        static int substractMethod (int number1, int number2)
        {
            return number1 - number2;
        }

    }
}
