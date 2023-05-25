using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Book? ");
        string book_title = Console.ReadLine();
        Console.Write("What is the chapter? ");
        string chapter_num = Console.ReadLine();
        Console.Write("What is the frist verse? ");
        string frist_string = Console.ReadLine();
        int first_verse = int.Parse(frist_string);
        Console.Write("What is the last verse(if there is only one verse, please enter 0)? ");
        string end_string = Console.ReadLine();
        int end_verse = int.Parse(end_string);
        Reference reference;
        if (end_verse == 0){
             reference = new Reference(chapter_num, book_title, first_verse);
        }
        else{
             reference = new Reference(chapter_num, book_title, first_verse, end_verse);
        }
        Console.Write("Please enter the scripture or scripturs ");
        string user_scripture = Console.ReadLine();
        Scripture scripture = new Scripture(reference, user_scripture);
        string user_choice = "e";
        while (user_choice != "quit"){
            reference.Display();
            scripture.Display();
            Console.WriteLine();
            user_choice = Console.ReadLine();
            Console.Clear();
            scripture.Hide_word();

        }

    }
}