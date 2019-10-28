using System;
using System.Collections.Generic;

namespace _37___Delegates_usage_in_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> workerList = new List<Employee>();
            workerList.Add(new Employee() {ID = 1, Name = "Alan", Salary = 1000 , Experience = 4 });
            workerList.Add(new Employee() {ID = 1, Name = "Chris", Salary = 9000 , Experience = 6 });
            workerList.Add(new Employee() {ID = 1, Name = "Vere", Salary = 3000 , Experience = 4 });
            
            Employee.PromoteEmployee(workerList);
        }
    }

    class Employee
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public int Salary {get; set;}
        public int Experience {get; set;}

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee Worker in employeeList)
            {
                if (Worker.Experience >= 5)
                {
                    Console.WriteLine(Worker.Name + "Has Been Promoted");
                }
            }
        }
    }
}
