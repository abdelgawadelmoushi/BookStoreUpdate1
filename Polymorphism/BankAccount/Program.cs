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
        if (Balance < 0)
        {
            Console.WriteLine("you do not have suff funds"); ;
        }
        else
        {
            Balance -= Amount;
        }

    }
    public void Deposite(double Amount)
    {
        Balance += Amount;

    }
    public void Transfer(double Amount)
    {
        if (Balance < 0)
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
