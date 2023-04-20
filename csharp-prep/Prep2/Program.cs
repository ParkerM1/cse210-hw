using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int grade_num = int.Parse(grade);

        if (grade_num >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        else if (grade_num < 90 && grade_num >= 80)
        {
            Console.WriteLine("Your grade is an B");
        }
        else if (grade_num < 80 && grade_num >= 70)
        {
            Console.WriteLine("Your grade is an C");
        }
        else if (grade_num < 70 && grade_num >= 60)
        {
            Console.WriteLine("Your grade is an D");
        }
        else
        {
            Console.WriteLine("Your grade is an F");
        }
        
        if (grade_num >= 70)
        {
            Console.Write("Congrats!! You passed the class!");
        }
        else
        {
            Console.Write("You did not pass the class :(");
        }
    }
}