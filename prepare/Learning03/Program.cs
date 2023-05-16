using System;

class Program
{
    static void Main(string[] args)
    {
        var savings = new Account();
        savings.Deposit(500);
        savings.Deposit(1000);
    }
}


public class Account {
    private List<int> transactoins = new List<int>();
    
    public void Deposit (int amount){
        transactoins.Add(amount);
    }

    public int Balance(){
        var balance = 0;
        foreach (var transactoin in transactoins){
            balance += transactoin;
        }

        return balance;
    }
}