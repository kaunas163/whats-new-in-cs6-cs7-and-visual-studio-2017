using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returning_by_reference
{
    public class SomeClass
    {
        public ref int Modifier(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }

            throw new ArgumentException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ob = new SomeClass();

            var numbers = new int[] {1, 2, 3, 4, 5, 6};
            Console.WriteLine(numbers[1]);
            ref int val = ref ob.Modifier(2, numbers);
            val = 10;
            Console.WriteLine(numbers[1]);
        }
    }
}
