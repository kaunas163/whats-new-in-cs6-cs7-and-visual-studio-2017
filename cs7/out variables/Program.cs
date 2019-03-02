using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_variables
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void GetCoords(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point() {X = 1, Y = 2};

            int xx, yy;
            point.GetCoords(out xx, out yy);

            point.GetCoords(out int x, out int y);

            Console.WriteLine($"X: {x}, Y: {y}");
            Console.WriteLine($"X: {xx}, Y: {yy}");

            string digit = "1";
            int.TryParse(digit, out int d);
            Console.WriteLine($"Parsed digit: {d}");
        }
    }
}
