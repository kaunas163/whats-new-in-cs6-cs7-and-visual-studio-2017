using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_interpolation
{
    public class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public override string ToString()
        {
            string oldWay = string.Format("Name: {0}, Health: {1}", Name, Health);
            string newWay = $"Name: {Name}, Health: {Health}";

            FormattableString formattableString = $"Name: {Name}, Health: {Health}";
            string invariant = FormattableString.Invariant(formattableString);

            return newWay;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
