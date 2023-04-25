using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Riddles number guessing game. You will be asked to give a number and your job will to guess the number from 1 to the number you enter");
        Console.Write("Please enter the maximum number you would like to use: ");
        string vaule_stg = Console.ReadLine();
        int vaule_max = int.Parse(vaule_stg);

        Random randomGenerator = new Random();
        int vaule_random = randomGenerator.Next(1, vaule_max);
        
        Console.WriteLine("Now you will be prompted to guess the Riddlers Number");
        Console.Write($"Guess the riddlers number between 1 and {vaule_stg}: ");
        string guess_stg = Console.ReadLine();
        int guess_number = int.Parse(guess_stg);

        while (guess_number != vaule_random)
        {
            if (guess_number < vaule_random)
            {
                Console.WriteLine("That number is lower then the Riddlers number");
                Console.Write("Try again: ");
                guess_stg = Console.ReadLine();
                guess_number = int.Parse(guess_stg);
            }
            if (guess_number > vaule_random)
            {
                Console.WriteLine("That number is higher then the Riddlers number");
                Console.Write("Try again: ");
                guess_stg = Console.ReadLine();
                guess_number = int.Parse(guess_stg);
            }
        }
        Console.WriteLine($"Well done, the Riddlers number is {vaule_random}");
    }
}