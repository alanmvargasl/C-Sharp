using System;

namespace _22___Method_Hiding_in_C_
{

    public class Employee
    {
        public string FirstName;
        public string Lastname;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + Lastname);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            base.PrintFullName();
        }
    }

    public class FullTimeEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Alan";
            FTE.Lastname = "Vargas";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Part Time";
            PTE.Lastname = "Employee";
            PTE.PrintFullName();
        }
    }
}
