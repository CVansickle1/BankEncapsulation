using BankEncapsulation;
using System.Collections.Generic;


double depositAmount;
Console.WriteLine("Hello would you like to make a deposit?");
Console.WriteLine("Only yes/no or y/n Allowed: ");
bool keepGoing = MoneyMoves.CheckIfDone(Console.ReadLine());
var yourAccount = new BankAccount(0);

while (keepGoing)
{ 
    Console.WriteLine("Please enter the ammount you would like to deposit");

    var nullCheck = double.TryParse(Console.ReadLine(), out depositAmount);

    while (!nullCheck)
    {
        Console.WriteLine("Please enter the ammount you would like to deposit");
        nullCheck = double.TryParse(Console.ReadLine(), out depositAmount);
    }

    yourAccount.Deposit(depositAmount);

    Console.WriteLine($"Your New Balance is: {yourAccount.GetBalance()} ");

    Console.WriteLine("Would You Like to Make another Deposit?");
    Console.WriteLine("Only yes/no or y/n Allowed: ");

    keepGoing = MoneyMoves.CheckIfDone(Console.ReadLine());

}

Console.WriteLine("See you next time!");
