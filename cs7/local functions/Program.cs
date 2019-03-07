using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_functions
{
    public class Customer
    {
        public string GetFullInfo(string fullStr)
        {
            return GetFullName(fullStr).firstName + GetFullName(fullStr).lastName;

            (string firstName, string lastName) GetFullName(string str)
            {
                return (str.Split()[0], str.Split()[1]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
