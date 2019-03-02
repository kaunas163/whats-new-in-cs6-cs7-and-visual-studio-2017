using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safe_navigation_operator
{
    public class Weapon
    {
        public string Name { get; }

        public Weapon(string name)
        {
            Name = name;
        }
    }

    public class Character
    {
        public Weapon Weapon { get; }
    }

    class Program
    {
        static bool ArmedByKnife(Character c)
        {
            //return c != null && c.Weapon != null && c.Weapon.Name == "Knife";
            return c?.Weapon?.Name == "Knife";
        }

        static void Main(string[] args)
        {
        }
    }
}
