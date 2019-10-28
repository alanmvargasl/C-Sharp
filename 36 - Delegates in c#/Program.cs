using System;

namespace _36___Delegates_in_c_
{



public delegate void myDelegate(int Number);

//Delegates are not so neccesary for now, since they only help you realize if you typed something wrong either on the delegate or on the method.
//It just points to the method.
    class Program
    {   
        static void Main(string[] args)
        {

        myDelegate D1 = new myDelegate(MyMethod);

            Console.WriteLine("Hello World!");
        }

        public static void MyMethod(int Number)
        {
            Console.WriteLine("My Number is  {0} ", Number);
        }
    }
}
