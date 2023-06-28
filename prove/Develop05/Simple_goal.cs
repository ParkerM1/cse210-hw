class Simple_goal: Goal{

    public Simple_goal(): base (){
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

    public Simple_goal(string name, string discription, int points): base(name, discription, points){
        
    }

    override public bool RecordEvent (){
        _complete = true;
        return true;
    }

    public override string GetData()
    {
        return $"Simple#{_name}#{_discription}#{_points}#{_complete}";
    }
}