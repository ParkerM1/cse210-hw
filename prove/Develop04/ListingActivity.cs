class ListingActivity:Activity{
    private List<string> _prompt = new List<string>(){
        "What are some of your hobbies or activity that brings you joy?"
        , "think of a person who has had a significant impact on your life and type their name."
        , "What some of your fondest childhood memory?"
        , "If you could travel anywhere in the world, where would you go?"
        , "Share a book, movie, or song that has deeply resonated with you."
        , "What is some of the most important life lessons you have learned so far?"
        , "List goals or dreams that you aspire to achieve in the future."
        , "Reflect on a moment of personal growth or overcoming a challenge that has made you stronger."
        , "List some cherished possessions that holds sentimental value."
        , "Imagine you could have a conversation with any historical figure who would it be? list any many as you can think."};
    private string _activtyDiscription = "This activity will ask you to answer questions and you will list all you answers";
    private int _pauseDuratoin = 7;

    public ListingActivity(){

    }

    public void Display_message(){
        Console.WriteLine($"{_activtyDiscription}");
        Console.WriteLine("");
    }

    public void Display_activity() {
        Activity activity = new Activity();
        activity.show_start();
        activity.Show_spinner(_pauseDuratoin);
        Console.WriteLine("");
        Console.Write("How long would you like to do this activity? ");
        string user_duration = Console.ReadLine();
        int new_duratoin = int.Parse(user_duration);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(new_duratoin);
        
        int num = activity.Random_num();
        string prompt = _prompt[num];
        Console.WriteLine($"{prompt}");
        
        int count = 0;
        while (futureTime > DateTime.Now){
            
            Console.Write("");
            Console.ReadLine();
            count = count +1;
            
        }
        Console.WriteLine($"You listed {count} things!!");
        Console.WriteLine("");
        activity.show_end(new_duratoin, "Reflecting Activity");
        Console.WriteLine("");
        Console.WriteLine("Please select another activity or enter quit");
        Console.WriteLine("");
    }
}