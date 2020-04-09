using System;


namespace bank_account {

    public static class Helper 
    {
        private static int accountNum = 0;

        public static int GenerateAccNum() 
        {
            return accountNum++;
        }
    }
    public class BankAccount
    {
        private string AccountHolder;
        private double Balance;
        private int AccountNum;

        public BankAccount(string accountHolderIn)
        {
            AccountHolder = accountHolderIn;
            Balance = 0;
            AccountNum = Helper.GenerateAccNum();
        }

        public void Display()
        {
            Console.WriteLine("__________");
            Console.WriteLine("Hello " + AccountHolder);
            Console.WriteLine("Your balance is " + Balance);
            Console.WriteLine("___________");
            Console.WriteLine("Your account number is " + AccountNum);
        }

        public void Deposit(double depAmount)
        {
            Balance += depAmount;
        }

        public void Withdraw(double witAmount) 
        {
            if (witAmount > Balance)
                Console.WriteLine("insufficent funds");
            else 
                Balance -= witAmount;
        }

       
}





    class Program
    {
        static void Main()
        {
            BankAccount b1 = new BankAccount("Danielle Murphy");
            b1.Deposit(50);
            b1.Withdraw(60);
            b1.Display();
            
            
            BankAccount B2 = new BankAccount("Daniel Maguire");   
            B2.Deposit(49);
            B2.Withdraw(8);
            B2.Display();
            

        }
    }
}
