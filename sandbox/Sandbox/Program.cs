using System;

class Program
{
    static void Main(string[] args)
    {
        var person_one = new Person("layne", "moseley");
        var person_two = new Person("David", "Hasselhoff");
        person_one.breathe();
        person_one.talk();
        person_two.talk();
    }
}

class Person {
    //attributes
    string firstname;
    string lastname;

    // construcotor
    public Person(string fn, string ln) {
        firstname = fn;
        lastname = ln;
    }

    // behavoirs
    public void breathe() {
        Console.WriteLine("breathing");
    }
    public void walk() {
        Console.WriteLine("walking");
    }

    public void talk() {
        Console.WriteLine($"hi, my name is {full_name()}");
    }

    public string full_name(){
        return firstname + "" + lastname;
    }
}