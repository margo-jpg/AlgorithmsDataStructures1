using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ConsoleKeyInfo tmp;
            int max = 0;
            int min = 0;
            int attempt = 0;
            int gamesCount = 0;
            do
            {
                int number = random.Next(1, 101);
                gamesCount++;
                int currentAttempt = 0;
                while (true)
                {

                    currentAttempt++;
                    int mysteryNumber = 0;
                    Console.WriteLine("Enter mystery number in [1,100]");
                    while (!int.TryParse(Console.ReadLine(), out mysteryNumber) || mysteryNumber < 1 || mysteryNumber > 100)
                        Console.WriteLine("Error Enter correct number in [1,100]");
                    if (mysteryNumber > number)
                        Console.WriteLine("Guess number is less");
                    else if (mysteryNumber < number)
                        Console.WriteLine("Guess number is more");
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                }
                attempt += currentAttempt;
                min = min == 0 || min > attempt ? attempt : min;
                //if (min > attempt) min = attempt;
                max = max < attempt ? attempt : max;
                tmp = Console.ReadKey();
            } while (tmp.Key == ConsoleKey.Y);
            Console.WriteLine($"Min = {min}\n" + $"Max = {max}\nAvg = {attempt * 1.0 / gamesCount}");
        }
    }
}