using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoproperties_and_immutability
{
    class Character
    {
        /*private readonly int armor;

        public int Armor
        {
            get { return armor; }
        }

        private void BadSpell()
        {
            //Armor = -1;
        }*/

        public int Armor { get; } = 100;

        public Character()
        {
            Armor = 90; // this will have priority
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            Console.WriteLine(character.Armor);
        }
    }
}
