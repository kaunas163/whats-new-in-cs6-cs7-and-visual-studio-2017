using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_filters
{
    class Program
    {
        private static bool Filter(ArgumentException ex)
        {
            return ex.Message == "bang";
        }

        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentException("bang");
            }
            catch (ArgumentException ex) when (Filter(ex))
            {
                Console.WriteLine(ex);
            }
        }
    }
}
