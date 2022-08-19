using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double Balance;
        public BankAccount(double balance)
        {
            Balance = balance;
        }

        public  void Deposit(double amount)
        {
            Balance += amount;
        }

        public double GetBalance()
        {
            return Balance;
            throw new NotImplementedException();

        }

        public void Withdraw(double amount)
        { 
            Balance -= amount;
        }

    }

    public class MoneyMoves
    {
        public static bool CheckIfDone(string ans)
        {
            ans.ToLower();
            while (true)
            {
                ;
                if (ans != null && (ans == "y" || ans == "yes"))
                {
                    return true;

                }
                else if (ans != null && (ans == "n" || ans == "no"))
                {
                    return false;

                }
                else
                {
                    Console.WriteLine("Only yes/no or y/n Allowed: ");
                    ans = Console.ReadLine();
                }
            }
        }

        private int _Pin;

        private void SetPin()
        {
            _Pin = 1234;
        }

        public bool CheckPin(int userPin)
        {
            SetPin();
            return (_Pin == userPin) ? true : false;
            
        }

        public static int GetInput()
        {
            bool numCheck;
            numCheck = int.TryParse(Console.ReadLine(), out int num);

            while (!numCheck)
            {
                Console.WriteLine("Please enter a number: ");
                numCheck = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }

    }


}
