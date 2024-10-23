using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checked_to_handle_overflow_and_underflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 150;
            byte b = 160;
            checked
            {
                byte c = (byte)(a + b);
                Console.WriteLine(c);
            }
            //This line will not execute since exception comes
            // If checked keyword will not there then you will not get the run time error. but the output is difficult to understand since we do not know weather 
            //  it was overflow or underflow.
        }
    }
}
