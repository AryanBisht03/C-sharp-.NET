using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_methods_in_structures
{
    struct new_class
    {
        public static int num(string s)
        {
            int number = int.Parse(s);
            return number;
        }
        public static int add(int x,int y)
        {
            return x + y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //new_class sr=new new_class();
            int a = new_class.num("12");
            int b = new_class.num("23");
            Console.WriteLine($"The sum of {a} and {b}  is {new_class.add(a,b)}");

        }
    }
}
