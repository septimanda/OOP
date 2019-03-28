using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, i;
            Console.Write("First Number : ");
            first = Convert.ToInt16(Console.ReadLine());
            Console.Write("Second Number : ");
            second = Convert.ToInt16(Console.ReadLine());

            i = 1;

            do {
                Console.Write(first + " + ");
                i++;
            }
            while ( i < second);
            Console.Write(first + " = " + result2(first, second));
            //result(first, second);
            Console.Read();
        }

        static void result(int a, int b) {
            Console.Write(a*b);
        }

        static int result2(int a, int b) {
            return a * b;
        }
    }
}
