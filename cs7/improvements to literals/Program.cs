using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improvements_to_literals
{
    class Program
    {
        static void Main(string[] args)
        {
            int cash = 1_387_254_00;
            Console.WriteLine(cash);

            int bitMask = 0b1000_1010_0010;
            Console.WriteLine(bitMask);
        }
    }
}
