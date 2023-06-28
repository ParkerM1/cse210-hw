class Check_goals: Goal{
    private int _bonus;
    private int _neededTimes;
    private int _userTimes = 0;

    public Check_goals(): base (){
        Goal goal = new Goal();
        Console.Write("What is the name of the goal? ");
        _name = Console.ReadLine();
        Console.Write("What will you be doing in this goal? ");
        _discription = Console.ReadLine();
        _points = goal.GetInteger();
        Console.Write("How many times do you want to do this goal? ");
        string st_neededTimes = Console.ReadLine();
        int _neededTimes = int.Parse(st_neededTimes);
         Console.Write("How much points do you want to get when you have complete your goal all the way? ");
        string st_bonus = Console.ReadLine();
        int _bonus = int.Parse(st_bonus);
        
       

        Console.WriteLine($"Your goal name: {_name}");
        Console.WriteLine("");
        Console.WriteLine($"Your goal discription: {_discription}");
        Console.WriteLine("");
        Console.WriteLine($"The points the goal is worth: {_points}");
        Console.WriteLine("");
        Console.WriteLine($"This is how many times you want to do the goal: {_neededTimes}");
        Console.WriteLine("");
        Console.WriteLine($"This is how many extra points you will get when you are done: {_bonus}");
    }

    public Check_goals(string name, string discription, int points, int neededTimes, int userTimes, int bouns): base(name, discription, points){
        _neededTimes = neededTimes;
        _userTimes = userTimes;
        _bonus = bouns;
    }

    override public bool RecordEvent (){
        _complete = true;
        _userTimes += 1;
        if (_userTimes == _neededTimes){
            return true;
        }
        else{
            return false;
        }
    }


    public override string GetData()
    {
        return $"Checklist#{_name}#{_discription}#{_points}#{_complete}#{_neededTimes}#{_userTimes}#{_bonus}";
    }
}