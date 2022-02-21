using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata;
            //siis mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();

            int cpuNumber = rnd.Next(1, 11);
            bool LoopActive = true;
            int i = 0;

            while (i < 3)

            {

                Console.WriteLine("Arve ära number ühest kümneni, teil on kokku 3 katset:");
                int guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == cpuNumber)

                {
                    Console.WriteLine("Palju õnne, oled mängu võitnud!");
                    break;
                }

                else
                {
                    i++;
                    Console.WriteLine($"Vale, proovi uuesti! Katseid jäänud {3 - (i)}");
                }
            }

            Console.WriteLine("Head päeva!");
        }
    }
}
