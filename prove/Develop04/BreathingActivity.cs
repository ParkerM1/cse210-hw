class BreathingActivity: Activity{
    private string _activtyDiscription = "This activity will have you breath in and out for the time you select to promote health and positve mental atitude";

    private int _pauseDuratoin = 6;
    public BreathingActivity(){

    }

    public void Display_message(){
        Console.WriteLine($"{_activtyDiscription}");
    }

    public void Display_activity() {
        Activity activity = new Activity();
        activity.show_start();
        activity.Show_spinner(_pauseDuratoin);
        Console.WriteLine("");
        Console.Write("How long would you like to do this activity? ");
        string user_duration = Console.ReadLine();
        int new_duratoin = int.Parse(user_duration);
        int breathin = 4;
        int breathout = 6;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(new_duratoin);

        while (futureTime > DateTime.Now){
        Console.WriteLine("Breath in");
        activity.Display_countdown(breathin);
        Console.WriteLine("breath out ");
        activity.Display_countdown(breathout);
        }

        activity.show_end(new_duratoin, "Breathing Activity");
        Console.WriteLine("");
        Console.WriteLine("Please select another activity or enter quit");
        Console.WriteLine("");
    }
}