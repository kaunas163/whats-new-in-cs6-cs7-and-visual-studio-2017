using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_initializers
{
    public class Character
    {
        public string Name { get; }
        public int Defense { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Defense: {Defense}";
        }
    }

    static class Extensions
    {
        internal static void Add(this IList<Character> characters, string name)
        {
            characters.Add(new Character(name));
        }
    }

    class Program
    {
        // try: use same key for both variants and see what happens

        /*private static readonly Dictionary<string, Character> Characters = new Dictionary<string, Character>()
        {
            { "Elf", new Character("Elf") { Defense = 100 } },
            { "Ork", new Character("Ork") { Defense = 150 } }
        };*/

        private static readonly Dictionary<string, Character> Characters = new Dictionary<string, Character>()
        {
            ["Elf"] = new Character("Elf") { Defense = 100 },
            ["Ork"] = new Character("Ork") { Defense = 150 }
        };

        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>()
            {
                new Character("Elf"),
                new Character("Ork")
            };

            List<Character> characters2 = new List<Character>()
            {
                "Elf",
                "Ork"
            };

            Console.WriteLine(Characters["Elf"]);
            Console.WriteLine(Characters["Ork"]);
        }
    }
}
