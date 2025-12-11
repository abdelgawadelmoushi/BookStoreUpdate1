using System.Runtime.Intrinsics.X86;

namespace challenge2
{
    internal class Program
    {

        internal class ClsCalculator
        {
        
            public static bool AreEqual<T>(T V1, T V2) => V1.Equals ( V2);




            
        }
        static void Main()
        {
           // bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            
           // bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            //bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);


           bool IsEqual = ClsCalculator.AreEqual<Account>(new Account("Mohamed", 2000), new Account("Mohamed", 2000));
            // Hint: override

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

    internal class Account
    {
        public  Account(string v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }


        public string V1 { get; }
        public int V2 { get; }
    }
}

