using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
           
            int cpuNumber = rnd.Next(1, 11);
            bool LoopActive = true;
            int i = -1;

            while(LoopActive)

            { 
               
                Console.WriteLine("Arve ära number ühest kümneni:");
                int guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == cpuNumber)

                {
                    Console.WriteLine("Palju õnne, oled mängu võitnud!");
                    LoopActive = false;
                }
                
                else
                {
                    i++;
                    Console.WriteLine($"Vale, proovi uuesti!");
                }
            }

            Console.WriteLine("Head päeva!");
            
            
        }
    }
}
