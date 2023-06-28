class Eternal_goal : Goal{
    public Eternal_goal(): base (){
        Goal goal = new Goal();
       Console.Write("What is the name of the goal? ");
        _name = Console.ReadLine();
        Console.Write("What will you be doing in this goal? ");
        _discription = Console.ReadLine();
        _points = goal.GetInteger();

        Console.WriteLine($"Your goal name: {_name}");
        Console.WriteLine("");
        Console.WriteLine($"Your goal discription: {_discription}");
        Console.WriteLine("");
        Console.WriteLine($"The points the goal is worth: {_points}");
    }

    public Eternal_goal(string name, string discription, int points): base(name, discription, points){
        
    }

    override public bool RecordEvent (){
        return true;
    }

    public override string GetData()
    {
        return $"Eternal#{_name}#{_discription}#{_points}#{_complete}";
    }
}