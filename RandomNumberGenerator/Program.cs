using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int x = 1; x <= 100000000; x++)
            {
                Random random = new Random();
                int diceOne = random.Next(1, 100);
                int diceTwo = random.Next(1, 100);
                int diceThree = random.Next(1, 100);

                Console.WriteLine(diceOne);
                Console.WriteLine(diceTwo);
                Console.WriteLine(diceThree);

                if (diceOne != diceTwo && diceOne != diceThree && diceTwo != diceThree)
                {
                    count++;
                }

                else if (diceOne == diceTwo && diceOne == diceThree && diceTwo == diceThree)
                {
                    Console.WriteLine("It's a match! It took " + count + " times!");
                    break;
                }
            }
        }
    }
}
