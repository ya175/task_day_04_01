using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day04_01
{
    internal class Account
    {
        private string _name;
        
        private decimal _balance;


        //
        public Account(string name, decimal startinBalance)
        {
            _name = name;
            _balance = startinBalance;
        }
        //6
        public bool Deposit(decimal amountToAdd)
        {
            if (amountToAdd > 0)
            {
                _balance += amountToAdd;
                return true;
            }
            return false;
        }
        //7
        public bool Withdraw( decimal amountToWithdarw) {
            if (amountToWithdarw > 0 && amountToWithdarw <= _balance)
            {
                _balance -= amountToWithdarw;
                return true;
            }
            return false;

        }
        //8
        public string Name
        {
            get { return _name; }
        }
        //9
        public void Print()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Balance: {_balance}");
        }



        //Methods
        //public void DisplayBalance();




    }
}
