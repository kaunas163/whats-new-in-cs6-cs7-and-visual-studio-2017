using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throwing_expressions
{
    public class Customer
    {
        public string GetSurname(string fullName)
        {
            var names = fullName.Split();
            return names.Length > 1 ? names[1] : throw new ArgumentException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
