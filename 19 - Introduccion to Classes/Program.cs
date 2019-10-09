using System;


class Car
{
  string ONE="";
  string TWO="";
  public Car (string one, string two)
  {
    this.ONE = one;
    this.TWO = two;
  }
  public void PrintInfo()
  {
     Console.WriteLine(ONE + TWO);
  }
}

namespace _19___Introduccion_to_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           //i will create a class object here.
           Car myCar = new Car("Hello","MyNIGGA");
           myCar.PrintInfo();
           
        }
    }
 


}
 