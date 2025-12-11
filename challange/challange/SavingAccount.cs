using System;
using System.Xml.Linq;

namespace challange
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; protected set; } = 0.05;

        public void ApplyInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"💰 Interest of {interest} applied to {Name}'s saving account.");
        }
        public override void Withdraw(double amount)
        {
            double interest = Balance * InterestRate; // ممكن تعتبرها مكافأة قبل السحب
            Balance -= interest; // نضيف الفائدة قبل الخصم

            if (amount > Balance)
            {
                Console.WriteLine($"❌ Insufficient funds in {Name}'s saving account.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"💸 {Name} withdrew {amount} after adding interest {interest}. New balance: {Balance} . AccountType{Type}" .Length );
        }

    }
}


    