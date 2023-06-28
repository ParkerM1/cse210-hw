using System;

class Program
{
    static void Main(string[] args)
    {
        var hourly = new HourlyEmployee(1000, "elon musk", 14);
        var salary = new SalaryEmployee(90000, "robert oppenheimer", 14);

        var employees = new List<Employee> {hourly, salary};
        foreach (var employee in employees){
            Console.WriteLine(employee._name);
            Console.WriteLine(employee.PayPeroidWages());
        }
    }
}

class Employee{
    public string _name;

    protected double _payPeroidLength;

    public Employee(string name, int payPeroidLength){
        _name = name;
        _payPeroidLength = payPeroidLength;
    }

    virtual public double PayPeroidWages(){
        return 0;
    }    
}

class HourlyEmployee: Employee{

    double _rate;
    
    public override double PayPeroidWages(){
        return _rate * 8 * _payPeroidLength;
    }

    public HourlyEmployee(double rate, string name, int payPeroidLength):base (name, payPeroidLength){
        _rate = rate;
    }
}

class SalaryEmployee: Employee{
    double _annualRate;

    override public double PayPeroidWages(){
        return (_payPeroidLength / 365.0) * _annualRate;
    }
     public SalaryEmployee(double annualRate, string name, int payPeroidLength):base (name, payPeroidLength){
        _annualRate = annualRate;
    }
}