using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}

class Assignment{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary(){

        return ($"{_studentName} - {_topic}");
    }
}


class Math_assignment: Assignment{
    private string _textbookSection;
    private string _problems;

    public Math_assignment(string studentName, string topic, string textbookSection, string problems): base (studentName, topic){
        _studentName= studentName;
        _topic = topic;
        _textbookSection = textbookSection;
        _problems = problems;
    } 

    public string GetHomeworkList(){
        return ($"{_studentName} - {_topic} /n Section {_textbookSection} Problems {_problems}");
    }
}

class WritingAssignment:Assignment {
    private string _title;

    public WritingAssignment(string studentName, string topic, string title): base(studentName, topic){
        _studentName= studentName;
        _topic = topic;
        _title = title;
    }

    public string GetWritingInfo(){
        return ($"{_studentName} - {_topic} /n {_title}");
    }
}