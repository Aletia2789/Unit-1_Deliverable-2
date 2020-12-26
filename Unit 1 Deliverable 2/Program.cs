using System;

namespace Unit_1_Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            int NumberofFlips;
            int CorrectCount=0;
            string HeadsorTailsGuess;
            
            Console.WriteLine("Welcome to The Cointn Toss Guessin Game!\n\tGuess Which Will Have More: Enter Heads or Tails Below");
            HeadsorTailsGuess = Console.ReadLine();

            Console.WriteLine("How Many Times Shall We Flip The Coin? Enter Number Below");
            NumberofFlips = int.Parse(Console.ReadLine()); 

            for (int i=0; i < NumberofFlips; i++)
            {
                Random randomgen = new Random();
                int flip = randomgen.Next(2);
                if (flip == 0)
                {
                    Console.WriteLine("Heads\n");
                    if (HeadsorTailsGuess == "Heads")
                    {
                        CorrectCount++;

                    }
          
                }
                else if (flip == 1)
                {
                    Console.WriteLine("Tails\n");
                 if (HeadsorTailsGuess == "Tails")
                    {
                        CorrectCount++;


                    }   
                }

            }
            double percentage = (double) (CorrectCount) /(double) ( NumberofFlips) * 100.0;

            Console.WriteLine("Your guess," + HeadsorTailsGuess + ", came up " + CorrectCount + ".");
            Console.WriteLine("Thats "+percentage+"%");
        }
    }
}
