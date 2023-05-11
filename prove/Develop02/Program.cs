using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int user_num = 9;
        Journal journal = new Journal();
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

                File_manager file_Manager = new File_manager();
                Journal user_file = file_Manager.Loadjournal(new_file);      
            }
            else if (user_num == 2){
                Console.Write("What is the file name? ");
                string new_file = Console.ReadLine();
                File_manager file_Manager = new File_manager();
                file_Manager.Save_Journal(journal, new_file);
            }
            else if (user_num == 3){
                Entry entry = new Entry();
                string user_date = entry.Date(); 

                Prompt prompt = new Prompt();
                string user_prompt = prompt.Random_prompt();

                Console.WriteLine($"{user_date}: {user_prompt}");
                Console.Write("");
                string new_entry = Console.ReadLine();

                entry.current_date = user_date;
                entry.prompt_used = user_prompt;
                entry.text = new_entry;
                journal.entry_list.Add(entry);
            }
            else if (user_num == 4){
                journal.Display();
            }
            }
    }
}

public class Journal 
{
    public List<Entry> entry_list = new List<Entry>();

    public void Display(){
        foreach (Entry entry in entry_list)
        {
            Console.WriteLine("");
            Console.WriteLine($"{entry.current_date}");
            Console.WriteLine($"{entry.prompt_used}");
            Console.WriteLine($"{entry.text}");
            Console.WriteLine("");
        }
    }
}

public class Entry
{
    public string text;
    
    public string current_date;

    public string prompt_used; 

    public void Display(){
        Console.WriteLine($"");
    }

    public string Date(){
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
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

public class File_manager
{
    public Journal Loadjournal(string filename){

        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal();

        foreach (string line in lines){
            string [] parts = line.Split(";");
            
            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            entry.current_date = date;
            entry.prompt_used =prompt;
            entry.text = text;
            
            journal.entry_list.Add(entry);
        }
        return journal;
    }
    
    public void Save_Journal(Journal journal, string filename){

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in journal.entry_list){
                string data = $"{entry.current_date};{entry.prompt_used};{entry.text}";
                outputFile.WriteLine(data);
            }
        }
    }    
}