using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_matching
{
    public class Circle
    {
        public int Radius { get; set; }
    }

    public class Triangle
    {
        public int SideAB;
        public int SideBC;
        public int SideAC;
    }

    class Program
    {
        static void StraightPatternMatching(object ob)
        {
            if (ob is int x || (ob is string s && int.TryParse(s, out x)))
            {
                Console.WriteLine($"X parsed with matching: {x}");
            }
        }

        static void SwitchCasePatternMatching(object ob)
        {
            switch (ob)
            {
                case Triangle t:
                {
                    Console.WriteLine($"AB: {t.SideAB}");
                }
                    break;
                case Circle c:
                {
                    Console.WriteLine($"Radius: {c.Radius}");
                }
                    break;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
