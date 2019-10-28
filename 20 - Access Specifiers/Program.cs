using System;

namespace _20___Access_Specifiers {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Roll No : ");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Course : ");
            string course = Console.ReadLine();
            Console.Write("Enter Student Email : ");
            string email = Console.ReadLine();
            Student student = new Student();
            // Can directly access the public members of the class
            student.name = name;
            student.rollno = rollno;
            // Can't directly access private or protected members of class
            // student.course = course;
            // student.email = email;
            student.SetCourse(course);
            student.SetEmail(email);
            student.Show();
            Console.WriteLine("Press any key to Exit ...");
            Console.ReadKey();
        }
        class Student {
            public string name;
            public int rollno;
            protected string course;
            private string email;
            public void Show() {
                Console.WriteLine("Student Name : " + this.name);
                Console.WriteLine("Student Roll No : " + this.rollno);
                Console.WriteLine("Student Course : " + this.course);
                Console.WriteLine("Student Email : " + this.email);
            }
            // This method allows to set value of protected course field
            public void SetCourse(string course) {
                this.course = course;
            }
            // This method allows to set value of private email field
            public void SetEmail(string email) {
                this.email = email;
            }
        }
    }
}
