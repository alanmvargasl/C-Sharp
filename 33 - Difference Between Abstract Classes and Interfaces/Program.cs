using System;

namespace _33___Difference_Between_Abstract_Classes_and_Interfaces
{

    public abstract class Customer
    {
        //An Abstract class can have fields, can have implementations for some of its members (methods) and interfaces cant.
        //An interface can inherit from multiple interfaces... an abstract class Cannot.
        int ID;
        public void Print()
        {
            Console.WriteLine("Print");        
        }
            
    }

    public interface ICostumer
    {
        void Print();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
