using System.Runtime.Intrinsics.X86;

namespace challengeGenaric
{


    class ClsCalculator

    {
        public static bool IsEqual<T>(T v1, T v2)
        {
            if (v1 == null)
                return false;
            return v1.Equals(v2);
        }
    }
   internal class Account

    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public  Account(string v1, double v2)

        {

            Name = v1;
            Balance = v2;

        }
        public override bool Equals(object? obj)
        {
            Account? account = obj as Account; // ممكن الاكونت يشيل قيمة نال  او اليوزر ميدخلش حاجه جوا الاكونت فيدي ايرور
            if (account == null)
                return false;
            return this.Name == account.Name && this.Balance== account.Balance ;
        }


    }

    internal class Program
    {
        static void Main()
        {
           // bool IsEqual = ClsCalculator.IsEqual<int>(10, 20);
            //bool IsEqual = ClsCalculator.IsEqual<string>("ABC", "ABC");
         //   bool IsEqual = ClsCalculator.IsEqual<double>(10.5, 20.5);


            bool IsEqual = ClsCalculator.IsEqual<Account>(new Account("Mohamed", 2000), new Account("Mohamed", 2000));
          //  Hint: override

            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }





        }
    }
}

