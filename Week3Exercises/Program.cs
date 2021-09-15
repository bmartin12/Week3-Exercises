
using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Palun sisesta oma matemaatika eksami punktid.");
            int matm = Int32.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Palun sisesta oma keemia eksami punktid.");
            int keemia = Int32.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("Palun sisesta oma bioloogia eksami punktid.");
            int bio = Int32.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(400);

            if (matm >= 85 && keemia >= 90 && bio >= 95)
            {
                Console.WriteLine("Saate õppida arstiks. :)");
            }
            else
            {
                Console.WriteLine("sorri liiga loll ei saa arstiks õppida ;(");
            }






        }
    }
}
