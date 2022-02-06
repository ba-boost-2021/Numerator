using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Numerator.Metehan
{
    internal class RandomNumberGuess
    {
        public static void Random() 
        {
            var Guess = int.Parse(Console.ReadLine());
            Console.Write("100'e kadar sayi tahmini: ");
            var rnd = new Random();
            Console.WriteLine($"sayi ({rnd})");
            var a = rnd.Next(100);
            while (Guess != a)
            {
                Console.WriteLine("-");
            }
            Console.WriteLine("+");
        }
    }
}
