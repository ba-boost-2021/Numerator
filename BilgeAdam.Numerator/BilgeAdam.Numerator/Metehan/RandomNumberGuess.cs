using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Numerator.Metehan
{
    public static class RandomNumberGuess
    {
        public static void RandomGuess() 
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

        public static void PswCreator()
        {
            var passLenght = int.Parse(Console.ReadLine());
            Console.Write("Sifre Uzunlugu: ");
            var guid = new Guid();
            Console.WriteLine($"sifre ({guid.ToString().Remove(0, passLenght)})");
        }
    }
}
