using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuples_and_deconstruction
{
    public class RocketLauncher
    {
        public (int mainSystemError, int subSystemError) LaunchRocket()
        {
            Launch();
            return (GetMainSystemState(), GetSubSystemState());
        }

        public (int, int) LaunchRocket2()
        {
            Launch();
            return (GetMainSystemState(), GetSubSystemState());
        }

        private int GetSubSystemState()
        {
            return 0;
        }

        private int GetMainSystemState()
        {
            return 0;
        }

        private void Launch()
        {

        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = y;
            Y = y;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RocketLauncher launcher = new RocketLauncher();

            // use tuples

            var results = launcher.LaunchRocket();
            Console.WriteLine(results.mainSystemError);
            Console.WriteLine(results.subSystemError);

            // use tuples without assigned names

            var results2 = launcher.LaunchRocket2();
            Console.WriteLine(results2.Item1);
            Console.WriteLine(results2.Item2);

            // deconstruct tuples

            // way #1
            (int first1, int second1) = launcher.LaunchRocket();

            // way #2
            (var first2, var second2) = launcher.LaunchRocket();

            // way #3
            var (first3, second3) = launcher.LaunchRocket();

            // way #4
            int first4, second4;
            (first4, second4) = launcher.LaunchRocket();
        }
    }
}
