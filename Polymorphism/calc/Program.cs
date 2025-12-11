
namespace Calc
{
    internal class Program
    {
       
        class BankAccount
        {
            public BankAccount(string bankName, string branchName, string branchAddress, string accountNumber, string accountCurrency, double balance)
            {
                BankName = bankName;
                BranchName = branchName;
                BranchAddress = branchAddress;
                AccountNumber = accountNumber;
                AccountCurrency = accountCurrency;
                Balance = balance;


            }

            public string BankName { get; set; }
            public string BranchName { get; set; }
            public string BranchAddress { get; set; }
            public string AccountNumber { get; set; }
            public string AccountCurrency { get; set; }
            public double Balance { get; set; }


            

            public void Withdraw(double Amount)
            {
                
                if (Balance < Amount)
                {
                    
                    Console.WriteLine("you do not have suff funds"); ;
                   
                }
                else
                {
                    double newBalance = Balance - Amount;
                    Console.WriteLine($"withdrawn Amount is {Amount}");
                    Console.WriteLine($"avaialable Balance is Amount int account {AccountNumber} is {newBalance}");
                    Console.WriteLine($"Account Number  is {AccountNumber}");
                }

            }
            public void Deposite(double Amount)
            {
                double newBalance = Balance + Amount;
                Console.WriteLine($"deposited Amount is {Amount}");
                Console.WriteLine($"avaialable Balance is Amount int account {AccountNumber} is {newBalance}");
                Console.WriteLine($"Account Number  is {AccountNumber}");

            }
            public void Transfer(double Amount)
                 
            {
                if (Balance < Amount)
                {
                    Console.WriteLine("you do not have suff funds"); ;
                }
                else
                {
                    Balance -= Amount;
                }


            }

            public void ChangePassword() { }
            public void CreatSubAccount() { }
            public void PrintStatement() { }
          

        }
       static void Main(string[] args )
        {

            BankAccount account1 = new BankAccount("FAB", "Cornich", "Corich Street", "2324234323432", "AED", 500);
           account1.Withdraw(100);
          account1.Deposite(500);
        }
    }
}