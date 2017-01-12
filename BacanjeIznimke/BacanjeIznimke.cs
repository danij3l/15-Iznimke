using System;

namespace Vsite.CSharp
{
    public static class Math
    {
        public static int Faktorjel(int broj)
        {
            // Dodati u metodu provjeru je li argument manji od 0 i u tom slučaju baciti iznimku tipa ArgumentOutOfRangeException s odogovarajućom porukom

            if (broj < 0)
                throw new ArgumentOutOfRangeException(nameof(broj), "----->Argument must be  >=0 ");

            int rezultat = 1;
            for (int i = 2; i <= broj; ++i)
                rezultat *= i;
            return rezultat;
        }

        public static int Povrh(int n, int k)
        {
            return Faktorjel(n) / (Faktorjel(k) * Faktorjel(n - k));
        }
    }

    public class BacanjeIznimke
    {
        static void Main(string[] args)
        {
            // TODO: Provjeriti vraćaju li donji pozivi metode očekivane rezultate
            try
            {
                int n = 0;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi biti 0! = 1
                n = 3;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi biti 3! = 6
                n = 5;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi biti 5! = 120


                n = -1;
                Console.WriteLine("{0}! = {1}", n, Math.Faktorjel(n)); // trebalo bi baciti iznimku!


                Console.WriteLine("GOTOVO!!!");
                Console.ReadKey();
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
