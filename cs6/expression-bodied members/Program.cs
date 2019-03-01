using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expression_bodied_members
{
    public class Character
    {
        //public int Armor { get; } = 100;
        public int Armor => 100; // expression-bodied member

        public int Wear { get; private set; } = 15;
        public int Health { get; private set; } = 100;

        /*public int Defense
        {
            get { return Wear >= Armor ? 0 : Armor - Wear; }
        }*/

        // only for properties with getters and without setters
        // also must be one liner
        public int Defense => Wear >= Armor ? 0 : Armor - Wear; // expression-bodied member

        /*public void Damage(int damage)
        {
            Health -= damage - Defense;
        }*/

        // must be one liner
        public void Damage(int damage) => Health -= damage - Defense; // expression-bodied member

        // expression-bodied members won't become lambda functions, so there is no performance penalty

        public Character()
        {
            
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
