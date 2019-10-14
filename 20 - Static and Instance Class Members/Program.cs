using System;

namespace _20___Static_and_Instance_Class_Members
{
    class Circle
    {
        static float _PI = 3.141F;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius=Radius;
        }

        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }
    
    
    



    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
