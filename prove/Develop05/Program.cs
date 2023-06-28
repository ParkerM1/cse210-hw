using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goalList = new List<Goal>();
        int allPoints = 0;
        string user_choice = "0";
        while (user_choice != "6"){
            Console.WriteLine("Welcome to the goal making program!");
            Console.WriteLine("");
            Console.WriteLine($"You have {allPoints} points");
            Console.WriteLine("");
            Console.WriteLine("1. Create goal");
            Console.WriteLine("2. Record goal");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Save file");
            Console.WriteLine("5. Load file");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            user_choice = Console.ReadLine();
            Console.WriteLine("");
            if (user_choice == "1"){
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Check goals");
                Console.Write("Please select what goal you would like to make: ");
                string goal_type = Console.ReadLine();
                if (goal_type == "1"){
                    var goal = new Simple_goal();
                    _goalList.Add(goal);
                }
                else if (goal_type == "2"){
                    var goal = new Eternal_goal();
                    _goalList.Add(goal);
                }
                else if (goal_type == "3"){
                     var goal = new Check_goals();
                    _goalList.Add(goal);
                }
            }
            else if (user_choice == "2"){
                Goal goal = new Goal();
                foreach (Goal item in _goalList){
                    Console.WriteLine(goal.CheckComplete(item) , "Name:" + item.get_name() + " - "+ "discrition: " + item.get_discipt() + " - "+ "points: " + item.get_points());
                }
                Console.Write("What goal do you want to complete ");
                var input = int.Parse(Console.ReadLine());
                var goalToComplete = _goalList[input - 1];
                goalToComplete.RecordEvent();
                var points = goalToComplete.get_points();
                allPoints = allPoints + points;
            }
            else if (user_choice == "3"){
                foreach (Goal item in _goalList){
                    item.get_name();
                    string dis_val = item.get_discipt();
                    Console.WriteLine("Name:" + item.get_name() + " - "+ "discrition: " + item.get_discipt() + " - "+ "points: " + item.get_points());
                }
            }
            else if (user_choice == "4"){
                Console.Write("What is the file name? ");
                string file_name = Console.ReadLine();
                File_manager file_Manager =  new File_manager();
                file_Manager.Save_file(file_name, _goalList);
            }
            else if (user_choice == "5"){
                Console.Write("What is the file name? ");
                string file_name = Console.ReadLine();
                File_manager file_Manager = new File_manager();
                file_Manager.Load_file(file_name);
            }
        }
    }
}