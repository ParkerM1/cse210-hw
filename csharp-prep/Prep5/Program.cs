using System;

class Program
{
    static void Main(string[] args)
    {
        display_hello();

        string user_name = prompt_user_name();
        int fav_num = prompt_user_num();
        int squ_num = number_square(fav_num);
        display_result(user_name, squ_num);
        static void display_hello()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string prompt_user_name()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int prompt_user_num()
        {
            Console.Write("What is your favorite number? ");
            string num_stg = Console.ReadLine();
            int num = int.Parse(num_stg);
            return num;
        }
        static int number_square(int num)
        {
            int squ = num * num;
            return squ;
        }
        static void display_result(string name, int squ)
        {
            Console.WriteLine($"{name}, the square of your number is {squ}");
        }
        
    }
}