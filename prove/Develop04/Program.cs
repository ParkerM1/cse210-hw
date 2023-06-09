using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfullness program");
        string choice = "9";
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        while (choice != "4"){
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1"){
                breathingActivity.Display_message();
                breathingActivity.Display_activity();
            }
            if (choice == "2"){
                reflectingActivity.Display_message();
                reflectingActivity.Display_activity();
            }
            if (choice == "3"){
                listingActivity.Display_message();
                listingActivity.Display_activity();                
            }
        }
    }
}