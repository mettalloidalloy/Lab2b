using System;

class MainClass {
  public static void Main (string[] args) {

Console.WriteLine("Enter salesperson's name.");
var name = Console.ReadLine();

Console.WriteLine("Enter sales amount.");
var x = Console.ReadLine();
int salesamount = Convert.ToInt32(x);

double commission = 200 + (0.09 * salesamount);

Console.WriteLine("Sales commission for " + name);
Console.WriteLine("is the amount of " + commission);


if (salesamount >= 0 && salesamount <= 2999)
    {
        Console.WriteLine("Performance is poor");
    }
else if (salesamount >= 3000 && salesamount <= 4999) 
    { 
        Console.WriteLine("Performance is average");
    }    
else if (salesamount >= 5000 && salesamount <= 9999) 
    { 
        Console.WriteLine("Performance is good");
    }        
else if (salesamount >= 10000 && salesamount <= 14999) 
    { 
        Console.WriteLine("Performance is excellent");
    }
else if (salesamount >= 15000) 
    { 
        Console.WriteLine("Performance is outstanding");
    }
   
  }
}