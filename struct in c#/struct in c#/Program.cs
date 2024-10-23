using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using struct_in_c_;

namespace struct_in_c_
{
    public struct employee
    {
        private int id;
        private string name;
        //public employee()
        //{
        //    Console.WriteLine("Hy");
        //}
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public employee(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your id is {id}");
        }
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        //normal contructor method
        employee e1 = new employee(22, "Aryan");
        e1.display();
        
        //normal initiazation using .operator
        employee e2 = new employee();
        e2.Name = "Pooja";
        e2.ID = 34;
        e2.display();

        //object initialization
        employee e3 = new employee()
        {
             ID=23,
             Name="Megha"
        };
        e3.display();
        }
    }

