using System;

namespace _26___Why_Properties
{

    public class Universe
    {
        private int _Earth; //With private property you can control what goes in and out of this variable!
        public int _Jupiter; //When in public, you cannot control what comes in and out of this variable.

        public void SetEarth(int Earth)
        {
            if(Earth <= 10)
            {
                throw new Exception ("Number must be bigger than 10");
            }
            this._Earth = Earth;
        }

        public int GetEarth()
        {
            return this._Earth;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Universe NEW = new Universe();
            NEW.SetEarth(11);
            Console.WriteLine(NEW.GetEarth());
        }
    }
}
