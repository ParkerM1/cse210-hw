class ReflectingActivity:Activity{
    private List<string> _prompt = new List<string>(){
    "How was your day today?"
    , "What was the best part of your day?"
    , "Did anything exciting happen today?"
    , "Was there anything challenging you had to deal with today?"
    , "Did you achieve any goals or accomplish something important?"
    , "Did you learn something new today? If so, what was it?"
    , "Did you have any interesting conversations or meet new people?"
    , "Did you do something creative or artistic today?"
    , "Was there a particular moment that made you smile or laugh?"
    , "Did you try something new or step out of your comfort zone today?"};
    private string _activtyDiscription = "This activity will ask you a question, and you will refect on this question for how long you set it for";
    private int _pauseDuratoin = 5;

    public ReflectingActivity(){

    }

    public void Display_message(){
        Console.WriteLine($"{_activtyDiscription}");
        Console.WriteLine("");
    }


    public void Display_activity() {
        Activity activity = new Activity();
        activity.show_start();
        activity.Show_spinner(_pauseDuratoin);
        Console.Write("How long would you like to do this activity? ");
        string user_duration = Console.ReadLine();
        
        int new_duratoin = int.Parse(user_duration);
        int refection_time = 10;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(new_duratoin);
        
        
        while (futureTime > DateTime.Now){
            int num = activity.Random_num();
            string prompt = _prompt[num];
            Console.WriteLine($"{prompt}");
            activity.Show_spinner(refection_time);
        }

        activity.show_end(new_duratoin, "Reflecting Activity");
        Console.WriteLine("");
        Console.WriteLine("Please select another activity or enter quit");
        Console.WriteLine("");
    }


}