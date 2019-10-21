using System;

namespace _29___Difference_Between_Classes_and_Structs_in_C_
{

    public class Customer
    {   
        public int ID {get;set;}
        public string Name {get;set;}

    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 10; // On a Struct!
            int j = i; // J gets a Copy of the value of i
            j = j+ 1; //But J is totally independent from i, and its changes will not affect the other.

            Console.WriteLine("i = {0}, and J = {1}", i,j);

            Customer C1 = new Customer();
            C1.ID = 1;
            C1.Name = "Alan";

            Customer C2 = C1;
            C2.Name = "Chris";
            //On a class type, when you copy a value to another, it points to the same MEMORY LOCATION.
            //So a change in one Class could affect the value on another class!
            Console.WriteLine("C1 Name = {0} and C2 Name = {1}", C1.Name, C2.Name);
        }

    }
}
