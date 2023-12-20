namespace task_day04_01
{
    enum MenuOptions
    {
        Withdraw=1, Deposit, Print, Quit

    }


    internal class Program
    {
        private static void ReadUserOptions(Account account)
        {
            MenuOptions option;
            int intOption;
            do
            {
                Console.WriteLine($"1-{MenuOptions.Withdraw}");
                Console.WriteLine($"2-{MenuOptions.Deposit}");
                Console.WriteLine($"3-{MenuOptions.Print}");
                Console.WriteLine($"4-{MenuOptions.Quit}");

                option = (MenuOptions)Convert.ToInt32(Console.ReadLine());
                intOption = Convert.ToInt32(option);

                switch (option)
                {

                    case MenuOptions.Deposit:
                        {
                            DoDeposit(account);
                            break;
                        }
                    case MenuOptions.Withdraw:
                        {
                            DoWithdraw(account);
                            break;
                        }
                    case MenuOptions.Print:
                        {
                            DoPrint(account);
                            break;
                        }
                    case MenuOptions.Quit:
                        { break; }
                }
            }

            while (intOption >= 1 && intOption <= 4);
        } 
    
        
        private static void DoDeposit(Account account)
        {
            Console.WriteLine("Enter the Number to add:");
            decimal amountToAdd=Convert.ToDecimal(Console.ReadLine());
           if( account.Deposit(amountToAdd)) Console.WriteLine($"{amountToAdd} added successfully.");
           else Console.WriteLine("unvalid amount ,please try again.");
        }
        private static void DoWithdraw(Account account) {
            Console.WriteLine("Enter the Number to withdraw:");
            decimal amountToWithdraw= Convert.ToDecimal(Console.ReadLine());
          if(  account.Withdraw(amountToWithdraw)) Console.WriteLine($"{amountToWithdraw} withdrawn successfully.");
            else Console.WriteLine("unvalid amount ,please try again.");
            
        }
        private static void DoPrint(Account account)
        { 
            account.Print();
        }

        static void Main(string[] args)
        {
            //11
            Account account = new Account("JAck", 20000);
            account.Print();
            account.Deposit(100);
            account.Print();

            //12
            account.Withdraw(100);
            account.Print();

            //13


            Account myAccount = new Account("yassmine", 100);
            myAccount.Print();
            myAccount.Deposit(400);
            myAccount.Print();
            myAccount.Withdraw(100);
            myAccount.Print();

            ReadUserOptions(myAccount); //400
    }
    }
}

