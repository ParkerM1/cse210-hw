using System;

class Program
{
    static void Main(string[] args)
    {
        var guess_nums = new List<int>();
        int guess_num = 1;
        while (guess_num != 0)
        {
            Console.Write("Please enter a number to add. To end enter 0: ");
            string guess = Console.ReadLine();
            guess_num = int.Parse(guess);
            guess_nums.Add(guess_num);
        } 
        int sum = 0;
        foreach (int num in guess_nums)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is {sum}");

        int len = (guess_nums.Count);
        float avg = (float) sum / (float) len;
        Console.WriteLine($"the average is {avg}");

        int max = guess_nums[0];
        foreach (int numb in guess_nums)
        {
            if (numb > max)
            {
                max = numb;
            }
        }
        Console.WriteLine($"The max number is {max}");
    }
}