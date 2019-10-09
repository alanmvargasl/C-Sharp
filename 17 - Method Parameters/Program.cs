using System;

namespace _17___Method_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int total =0;
            int product =0;
            calculate(10,20,out total, out product);
            Console.WriteLine("Sum ={0} && Product = {1}", total, product);

        }
        public static void calculate (int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN+SN;
            Product = FN*SN;
        }
    }
}
