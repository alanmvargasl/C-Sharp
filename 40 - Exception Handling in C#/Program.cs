using System;
using System.IO;

namespace _40___Exception_Handling_in_C_
{
    
    //Awesome, very important!
    class Program
    {
        static void Main(string[] args)
        {
           try{
           StreamReader reader = new StreamReader(@"C:\Github\C-Sharp\40 - Exception Handling in C#\Data.txt");
           Console.WriteLine(reader.ReadToEnd());
           reader.Close();
           }
           catch(FileNotFoundException error){
            Console.WriteLine("Your File in File Location {0} was not found", error.FileName);
           }
           catch(DirectoryNotFoundException error){
            Console.WriteLine(error.Message);
           }
          
        }
    }
}
