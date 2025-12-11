namespace challange
{
  
    

        internal class Program
        {


      
     
            static void Main(string[] args)
            {


                List<Account> accounts = new List<Account>
             {
                new Account() { Number = 111, Name = "Amr", Type="Account"},
                new Account() { Number = 222, Name = "Sara" , Type="Account" },
                new SavingAccount() { Number = 333, Name = "Ali" , Type="SavingAccount"},
                new SavingAccount() { Number = 444, Name = "Lina" , Type="SavingAccount"},
                new CurrentAccount () {Number = 555, Name = "fawzy", Type="CurrentAccount"},
                new CurrentAccount () {Number = 666, Name = "Mona", Type="CurrentAccount"}
            };

            Console.WriteLine("🏦 Welcome to the Simple Banking System\n");

                while (true)
                {
                    Console.WriteLine("\n=== Available Accounts ===");
                    foreach (var acc in accounts)
                        acc.DisplayInfo();

                    Console.Write("\nEnter Account Number (or 0 to Exit): ");
                    double accNum = Convert.ToDouble(Console.ReadLine());

                    if (accNum == 0)
                    {
                        Console.WriteLine("👋 Thank you for using our bank system!");
                        break;
                    }

                    // 🔎 البحث عن الحساب
                    Account selected = accounts.Find(a => a.Number == accNum);

                    if (selected == null)
                    {
                        Console.WriteLine("❌ Account not found. Please try again.");
                        continue;
                    }

                    // 🎯 عرض قائمة العمليات
                    Console.WriteLine($"\nSelected Account: {selected.Name}");
                    Console.WriteLine("1️⃣ Deposit");
                    Console.WriteLine("2️⃣ Withdraw");
                    Console.WriteLine("3️⃣ Check Balance");
                    Console.WriteLine("4️⃣ Apply Interest (for Saving Accounts)");
                    Console.WriteLine("0️⃣ Back to Main Menu");
                    Console.Write("Choose option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter deposit amount: ");
                            selected.Deposit(Convert.ToDouble(Console.ReadLine()));
                     
                        break;

                        case "2":
                            Console.Write("Enter withdraw amount: ");
                            selected.Withdraw(Convert.ToDouble(Console.ReadLine()));
                            break;

                        case "3":
                            Console.WriteLine($"💳 Current Balance: {selected.Balance}");
                            break;

                        case "4":
                            if (selected is SavingAccount sa)
                                sa.ApplyInterest();
                            else
                                Console.WriteLine("❌ This is not a saving account.");
                            break;

                        case "0":
                            continue;

                        default:
                            Console.WriteLine("❌ Invalid choice.");
                            break;
                    }
                }
            }
        }
    }