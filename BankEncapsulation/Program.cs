using BankEncapsulation;
using System.Collections.Generic;



Console.WriteLine("Hello Thank you for choosing this bank!");
Console.WriteLine("Please enter your Pin: ");
var mm = new MoneyMoves();
var userInput = MoneyMoves.GetInput();
var isAuthentic = mm.CheckPin(userInput);
var trys = 1;


while (!isAuthentic)
{

    Console.WriteLine("That wasnt right please try again");
    userInput = MoneyMoves.GetInput();
    isAuthentic = mm.CheckPin(userInput);
    trys++;
    if (trys >= 3)
    {
        Console.WriteLine("Too Many tries.. Goodbye");
        break;
    }
}
    



while (isAuthentic)
{
    bool allDone = false;
    var yourAccount = new BankAccount(0);
    while (!allDone)
    {
        Console.WriteLine("Please choose what you would like to do:");
        Console.WriteLine("1: Deposit \n2: Withdraw \n3: Check Balance \n4: All Done");
        var choice = MoneyMoves.GetInput();
        bool nullCheck;
        var keepgoing = true;



        switch (choice)
        {

            case 1:
                {
                    while (keepgoing)
                    {
                        double depositAmount;
                        Console.WriteLine("Please enter the ammount you would like to deposit");

                        nullCheck = double.TryParse(Console.ReadLine(), out depositAmount);

                        while (!nullCheck)
                        {
                            Console.WriteLine("Please enter the ammount you would like to deposit");
                            nullCheck = double.TryParse(Console.ReadLine(), out depositAmount);
                        }

                        yourAccount.Deposit(depositAmount);

                        Console.WriteLine("Would You Like to Make another Deposit?");
                        Console.WriteLine("Only yes/no or y/n Allowed: ");

                        keepgoing = MoneyMoves.CheckIfDone(Console.ReadLine());


                    }
                    break;
                }
            case 2:
                {
                    double withdrawAmount;
                    
                    while (keepgoing)
                    {
                        Console.WriteLine("Please enter the amount you would like to withdraw");

                        nullCheck = double.TryParse(Console.ReadLine(), out withdrawAmount);

                        while (!nullCheck)
                        {
                            Console.WriteLine("Please enter the ammount you would like to deposit");
                            nullCheck = double.TryParse(Console.ReadLine(), out withdrawAmount);
                        }
                        yourAccount.Deposit(withdrawAmount);

                        Console.WriteLine("Would You Like to Make another Deposit?");
                        Console.WriteLine("Only yes/no or y/n Allowed: ");

                       keepgoing = MoneyMoves.CheckIfDone(Console.ReadLine());
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Your account Balance is: ");
                    Console.WriteLine(yourAccount.GetBalance());
                    break;
                }
            case 4:
                {
                    allDone = true;
                    break;
                }
            default:
                {
                    Console.WriteLine("Not a valid Selection Please try agian");
                    Console.WriteLine("Please choose what you would like to do:");
                    Console.WriteLine("1: Deposit \n2: Withdraw \n3: Check Balance \n4: All Done");
                    choice = MoneyMoves.GetInput();
                    break;

                }

        }
    }

    Console.WriteLine("See you Next Time!");

    break;
}
