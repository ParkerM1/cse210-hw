using System;

class Program
{
    static void Main(string[] args)
    {
        string user_choice = "4";
        while (user_choice != "3"){
            Console.WriteLine("Welcome to the Rexburg student rental service!");
            Console.WriteLine("");
            Console.WriteLine("1. See which vehicles are available");
            Console.WriteLine("2. See how much it would be to rent a vehicle");
            Console.WriteLine("3. quit");
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            user_choice = Console.ReadLine();
            if (user_choice == "1"){

            }
            else if (user_choice == "2"){

            }
            else if (user_choice == "3"){
                Console.WriteLine("Thank you for using Rexburg student rental service!");
            }
            else{
                Console.WriteLine("");
                Console.WriteLine("You did not enter a correct input. Please try again.");
                Console.WriteLine("");
            } 
        }
    }
}