using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking_the_datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            byte b = 1;
            byte c = 14;
            int d = (byte)(a + b);
            Console.WriteLine(d);

        }
    }
}
