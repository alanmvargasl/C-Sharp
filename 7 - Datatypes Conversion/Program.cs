using System;

namespace _7___Datatypes_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumber = "100447";
            int result=0;
            bool isConversionSuccessful = int.TryParse(strNumber,out result);

            if (isConversionSuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.Write("Please Enter a Valid Number");
            }
        }
    }
}
