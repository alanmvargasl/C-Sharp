using System;

namespace _6___Nullable_Types
{ //Coalescing Operator and N
    class Program
    {
        static void Main(string[] args)
        {
           int Age = 24;

            //Coalescing Operator
            bool myAnswer = Age >= 18 ? true:false;
            Console.WriteLine("Is Alan An ADULT? " + myAnswer);

            //Null Coalescing Operator ??
            int? Age1 = null;
            int isTheValueNull = Age1 ?? 0;
            Console.WriteLine(isTheValueNull);
        }
    }
}
