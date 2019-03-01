using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using import_statics.Annotations;
using static System.Math;
using static import_statics.Type;

namespace import_statics
{
    public enum Type
    {
        Elf,
        Ork
    }

    public class Character
    {
        public Type Type { get; }

        public int Armor
        {
            get
            {
                switch (Type)
                {
                    case Elf:
                        return (int) Pow(8, 2);
                    case Ork:
                        return (int) Pow(10, 2);
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public Character(Type type)
        {
            Type = type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
