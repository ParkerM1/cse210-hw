class File_manager{
    public void Load_file (string filename){

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            string [] parts = line.Split("#");
            
            string goalType = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "Simple"){
                var goal = new Simple_goal();
            } else if (goalType == "Eternal"){
                var goal = new Eternal_goal();
            }else if (goalType == "Checklist"){
                var _neededTimes = int.Parse(parts[5]);
                var _userTimes = int.Parse(parts[6]);
                int bouns = int.Parse(parts[7]);
                var goal = new Check_goals();
            }
        }
    }

    public void Save_file (string filename, List<Goal> goals){
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in goals){
                string data = entry.GetData();
                outputFile.WriteLine(data);
            }
        }
    }
}   