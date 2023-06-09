class Activity {

    private string _startingMessage = "Thank you for using the program, please be patient while the program loads";
    private string _endingMessage = "Thank you for completing your activity.";

    private int _howLong;

    public Activity(){

    }

    public Activity (int howLong){
        howLong = _howLong;
    }


    public void Show_spinner (int duration){
        List<string> animations = new List<string> {
            "-",
            "\\",
            "|",
            "/",
        };
    
        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);
        int animationIndex = 0;
        while (DateTime.Now < endTime){
            string frame = animations[animationIndex];
            Console.Write(frame);

            Thread.Sleep(250);
            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animations.Count){
                animationIndex = 0;
            }
        }

        Console.WriteLine("");
    }

    public void Display_countdown(int duration){
        int currentValue = duration;
        while (currentValue >0 ){
            Console.Write(currentValue);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            currentValue--;
        }
    }

    public int Random_num(){
        Random randomGenerator = new Random();
        int vaule_random = randomGenerator.Next(0,10);
        return vaule_random;
    }

    public void show_start(){
        Console.WriteLine($"{_startingMessage}");
    }

    public void show_end(int user_duration, string user_activity){
        Console.WriteLine($"{_endingMessage} You have completed another {user_duration} seconds in {user_activity}");
    }
}