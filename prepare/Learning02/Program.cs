using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job();
        job1.job_title = "Software Enginger";
        job1.compony = "Mircosoft";
        job1.start_year = 2011;
        job1.end_year = 2020;

        var job2 = new Job();
        job2.job_title = "Software Enginger";
        job2.compony = "Apple";
        job2.start_year = 2009;
        job2.end_year = 2016;        

        Resume my_resume = new Resume();
        my_resume.name = "allison rose";
        
        my_resume.list_job.Add(job1);
        my_resume.list_job.Add(job2);
        
        my_resume.Display();
    }
}

class Resume{
    public string name;
    public List<Job> list_job = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");

        
        foreach (Job job in list_job)
        {
            job.Display();
        }
    }
}

public class Job{
    public string compony;
    public string job_title;
    public int start_year;
    public int end_year;

    public void Display(){
        Console.WriteLine($"{job_title} ({compony}) {start_year}-{end_year}");
    }
}