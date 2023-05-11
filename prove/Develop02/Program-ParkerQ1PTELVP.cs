using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int user_num = 9;
        while (user_num != 5){
            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine("");
            Console.WriteLine("1. Load file");
            Console.WriteLine("2. Save file");
            Console.WriteLine("3. Write new entry");
            Console.WriteLine("4. Look at my journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("What would you like to do in your journal? (Please enter 1-5 to use your journal): ");
            string user = Console.ReadLine();
            user_num = int.Parse(user);


            if (user_num == 1){
                Console.Write("What is the file name? ");
                string new_file = Console.ReadLine();

                var file1 = new File_manager();
                file1.file_name = new_file; 

                file1.Save_file();
            }
            else if (user_num == 2){

            }
            else if (user_num == 3){

            }
            else if (user_num == 4){

            }
            }
    }
}

class Journal 
{
    public List<string> entry_list = new List<string>();

    public void Display(){
        foreach (string entery in entry_list)
        {
            Console.WriteLine($"{entery}");
        }
    }
}

class Entry
{
    public string text;
    
    public string current_date;

    public string prompt_used; 

    public void Display(){
        Console.WriteLine($"");
    }

    public string Date(){
        string datetime = DateTime.Now.ToString("M/d/yyyy");
        return datetime;
    }
}


public class Prompt
{
    public List<string> prompt_list = new List<string>{
        "What was the name of someone you met today?",
        "What was the weather like today?",
        "What did you eat for lunch today?",
        "What meal was your favortie today?",
        "What did you do for fun today?"
    };
    
    public int Random_num(){
        Random randomGenerator = new Random();
        int vaule_random = randomGenerator.Next(1, 5);
        return vaule_random;
    }

 
    public string Random_prompt(){
        int random_index = Random_num();
        string prompt = prompt_list[random_index];
        return prompt;
    }
}

class File_manager
{
    public string file_name;

    public string complete_entry;

    public string[] Load_file(){
        string[] lines = System.IO.File.ReadAllLines(file_name);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    return lines;
    }

    public void Save_file(){
        string fileName = $"{file_name}";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{complete_entry}");
        }
    }    
}