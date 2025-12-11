using System;

namespace challange
{
    public class Account
    {
        public double Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Balance { get; protected set; }
        public string Type { get; set; }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("❌ Deposit amount must be greater than 0");
                return;
            }

            Balance += amount;
            Console.WriteLine($"✅ {amount} deposited to {Name}'s account.");
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"❌ Insufficient funds in {Name}'s account.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"💸 {amount} withdrawn from {Name}'s account.");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"[{Number}] {Name} — Balance: {Balance}  - AccountType : {Type}" );
        }

      
    }


}

