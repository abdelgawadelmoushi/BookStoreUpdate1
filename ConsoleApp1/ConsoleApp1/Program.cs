namespace ConsoleApp1 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter value 1");

            string FirstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("please enter value 2");

            string LastName = Convert.ToString(Console.ReadLine());

            string result = FirstName + LastName;


            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
