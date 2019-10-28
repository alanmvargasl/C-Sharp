using System;

namespace _38___Delegates_usage_in_c__continued
{
    //This is pretty cool, we can use delegates to invoke 1 or more methods at the same time.
    //This delegates are called MULTICAST DELEGATES
    public delegate void myDelegate();
    
        class Program
    {
        static void Main(string[] args)
        {
            myDelegate example = new myDelegate(myMethod1);
            example += myMethod2;
            example += myMethod3;
            example();
        }

        public static void myMethod1()
        {
            Console.WriteLine("Method 1 Invoked");    
        }

        public static void myMethod2()
        {
            Console.WriteLine("Method 2 Invoked");    
        }

        public static void myMethod3()
        {
            Console.WriteLine("Method 3 Invoked");    
        }

    }
}
