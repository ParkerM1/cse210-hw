using System;

class Program
{
    static void Main(string[] args)
    {
        
}
}

class Person{
    protected string _name;

    public Person(string name){
        _name = name;
    }
}

class BYUI_Person: Person{
    protected string _iNumber;

    public BYUI_Person(string name, string iNumber): base(name){
        _iNumber= iNumber;
    }
}

class Student: BYUI_Person {
   private string _major;

   public Student(string name, string iNumber, string major): base(name, iNumber){
    _major= major;
   }
}

class Teacher: BYUI_Person{
    private string _department;

    public Teacher(string name, string iNumber, string department): base(name, iNumber){
    _department = department;
   }
}