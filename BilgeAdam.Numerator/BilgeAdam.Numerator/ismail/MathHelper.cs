using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Numerator.ismail
{
    internal class MathHelper
    {
        public static double Square(double number) { return Math.Sqrt(number); }

        public static void Total(int number, int number2)
        {
            var result = number + number2;
            Console.WriteLine($"toplam {result}");
        }

    }
}
