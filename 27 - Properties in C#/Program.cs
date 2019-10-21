using System;

namespace _27___Properties_in_C_
{
    public class ME
    {
        private int age;

        public int setAge
        {
            set { if (value <= 0)
            {
            Console.WriteLine("Please type a number bigger than 0");
            }
            this.age = value;
            }
            get {
               return this.age;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ME alansage = new ME();
            alansage.setAge = 0;
            Console.WriteLine(alansage.setAge) ;
        }
    }
}
