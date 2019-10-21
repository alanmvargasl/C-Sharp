using System;

namespace _28___Structs_in_C_
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public string Name{
            get {return _name;}
            set {_name = value;}
        }
        public int ID{
            get {return this._id;}
            set {this._id = value;}
        }
        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails ()
        {
            Console.WriteLine("ID = {0} && Name = {1}", this._id, this._name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(1,"Alan");
            C1.PrintDetails();

            Customer C2 = new Customer();
            C2.ID = 2;
            C2.Name = "Chris";
            C2.PrintDetails();

            Customer C3 = new Customer
            {
                ID = 3,
                Name = "Verenice"
            };
            C3.PrintDetails();
        }
    }
}
