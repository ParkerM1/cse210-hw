class Goal {
    protected string _name;
    protected string _discription;
    protected int _points;
    protected bool _complete;



    virtual public bool RecordEvent (){
        return false;
    } 

    public Goal (){
        
    }

    public Goal(string name, string discription, int points){
        _name = name;
        _discription = discription;
        _points = points;
    }

    public int get_points (){
        return _points;
    }

    public string get_name (){
        return _name;
    }

    public string get_discipt (){
        return _discription;
    }

    public int GetInteger(){
        while (true){
            Console.Write("How much points is your goal? ");
            var input = Console.ReadLine();
            try {
                var value = int.Parse(input);
                return value;
            }
            catch(Exception) {
                Console.WriteLine("Incorrect input, please input a number!");
            }
        }
    }

    virtual public string GetData(){
        return"";
    }

    public string CheckComplete(Goal the_goal){
        if (the_goal._complete == true){
            string check = "{X}";
            return check;
        }
        else{
            string check = "{ }";
            return check;
        }
    }
}