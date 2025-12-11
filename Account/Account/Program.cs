namespace Account
{
    internal class Program
    {

        public class CheckingAccount : Account
        {
            private double withdrawFee = 1.50;

            public CheckingAccount(string name = "Unnamed Account", double balance = 0.0)
                : base(name, balance)
            {
            }

            public override bool Withdraw(double amount)
            {
                double totalAmount = amount + withdrawFee;
                if (balance - totalAmount >= 0)
                {
                    balance -= totalAmount;
                    return true;
                }
                return false;
            }

            public override string ToString()
            {
                return $"[CheckingAccount: Balance={balance}, Fee={withdrawFee}]";
            }
        }


        public class TrustAccount : SavingsAccount
        {
            private int withdrawCount;
            private const int MaxWithdrawals = 3;
            private const double BonusAmount = 50.0;

            public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double interestRate = 0.0)
                : base(name, balance, interestRate)
            {
                withdrawCount = 0;
            }

            public override bool Deposit(double amount)
            {
                if (amount >= 5000)
                    balance += BonusAmount;

                return base.Deposit(amount);
            }

            public override bool Withdraw(double amount)
            {
                if (withdrawCount >= MaxWithdrawals)
                    return false;

                if (amount > balance * 0.25)
                    return false;

                if (base.Withdraw(amount))
                {
                    withdrawCount++;
                    return true;
                }

                return false;
            }

            public override string ToString()
            {
                return $"[TrustAccount: Balance={balance}, Withdrawals={withdrawCount}/{MaxWithdrawals}]";
            }
        }


        public class SavingsAccount : Account
        {
            private double interestRate;
            private int withdrawCount;

            public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double interestRate = 0.0)
                : base(name, balance)
            {
                this.interestRate = interestRate;
                this.withdrawCount = 0;
            }

            public override bool Deposit(double amount)
            {
                if (amount <= 0)
                    return false;



                balance += amount + (amount * interestRate / 100);
                return true;
            }

            public override bool Withdraw(double amount)
            {
                if (withdrawCount >= 3)
                    return false;

                if (base.Withdraw(amount))
                {
                    withdrawCount++;
                    return true;
                }

                return false;
            }

            public override string ToString()
            {
                return $"[SavingsAccount: Balance={balance}, InterestRate={interestRate}%, Withdrawals={withdrawCount}]";
            }
        }

        public class Account
        {

            private string name;
            protected double balance;

            public Account(string name = "Unnamed Account", double balance = 0.0)
            {
                this.name = name;
                this.balance = balance;
            }

            public virtual bool Deposit(double amount)
            {
                if (amount < 0)
                    return false;
                else
                {
                    balance += amount;
                    return true;
                }
            }

            public virtual bool Withdraw(double amount)
            {
                if (balance - amount >= 0)
                {
                    balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public double GetBalance()
            {
                return balance;
            }

            public override string ToString()
            {
                return $"[Account: {name}: {balance}]";
            }




            public static class AccountUtil
            {
                // Utility helper functions for Account class

                public static void Display<T>(List<T> accounts) where T : Account
                {
                    Console.WriteLine("\n=== Accounts ==========================================");
                    foreach (var acc in accounts)
                    {
                        Console.WriteLine(acc);
                    }
                }

                public static void Deposit<T>(List<T> accounts, double amount) where T : Account
                {
                    Console.WriteLine("\n=== Depositing to Accounts =================================");
                    foreach (var acc in accounts)
                    {
                        if (acc.Deposit(amount))
                            Console.WriteLine($"Deposited {amount} to {acc}");
                        else
                            Console.WriteLine($"Failed Deposit of {amount} to {acc}");
                    }
                }

                public static void Withdraw<T>(List<T> accounts, double amount) where T : Account
                {
                    Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
                    foreach (var acc in accounts)
                    {
                        if (acc.Withdraw(amount))
                            Console.WriteLine($"Withdrew {amount} from {acc}");
                        else
                            Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
                    }
                }

                // Helper functions for Savings Account class

                // Helper functions for Checking Account class

                // Helper functions for Trust account class
            }

            static void Main(string[] args)
            {





                {
                    // Accounts
                    var accounts = new List<Account>();
                    accounts.Add(new Account());
                    accounts.Add(new Account("Larry"));
                    accounts.Add(new Account("Moe", 2000));
                    accounts.Add(new Account("Curly", 5000));

                    AccountUtil.Display(accounts);
                    AccountUtil.Deposit(accounts, 1000);
                    AccountUtil.Withdraw(accounts, 2000);

                    // Savings
                    var savAccounts = new List<SavingsAccount>();
                    savAccounts.Add(new SavingsAccount());
                    savAccounts.Add(new SavingsAccount("Superman"));
                    savAccounts.Add(new SavingsAccount("Batman", 2000));
                    savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

                    AccountUtil.Display(savAccounts);
                    AccountUtil.Deposit(savAccounts, 1000);
                    AccountUtil.Withdraw(savAccounts, 2000);

                    // Checking
                    var checAccounts = new List<CheckingAccount>();
                    checAccounts.Add(new CheckingAccount());
                    checAccounts.Add(new CheckingAccount("Larry2"));
                    checAccounts.Add(new CheckingAccount("Moe2", 2000));
                    checAccounts.Add(new CheckingAccount("Curly2", 5000));

                    AccountUtil.Display(checAccounts);
                    AccountUtil.Deposit(checAccounts, 1000);
                    AccountUtil.Withdraw(checAccounts, 2000);
                    AccountUtil.Withdraw(checAccounts, 2000);

                    // Trust
                    var trustAccounts = new List<TrustAccount>();
                    trustAccounts.Add(new TrustAccount());
                    trustAccounts.Add(new TrustAccount("Superman2"));
                    trustAccounts.Add(new TrustAccount("Batman2", 2000));
                    trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

                    AccountUtil.Display(trustAccounts);
                    AccountUtil.Deposit(trustAccounts, 1000);
                    AccountUtil.Deposit(trustAccounts, 6000);
                    AccountUtil.Withdraw(trustAccounts, 2000);
                    AccountUtil.Withdraw(trustAccounts, 3000);
                    AccountUtil.Withdraw(trustAccounts, 500);

                    Console.WriteLine();



                }
            }
        }
    }
}
