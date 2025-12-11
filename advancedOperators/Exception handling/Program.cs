namespace Exception_handling
{
    internal class Program
    {















static void Main(string[] args)
        {
            #region Basic Example


            //try
            //{
            //    int x = 10, y = 0;
            //    int result = x / y;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero!");
            //}
            //finally
            //{
            //    Console.WriteLine("Execution finished.");
            //}


            #endregion



            #region Multiple Catch Blocks

            //try
            //{
            //    int[] arr = new int[3];
            //    Console.WriteLine(arr[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Index is out of range!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}


            #endregion




            #region Throwing Exceptions

            //void Withdraw(decimal amount)
            //{
            //    if (amount <= 0)
            //        throw new ArgumentException("Amount must be greater than zero");
            //}

            #endregion




            #region Custom Exceptions

            //    public class InvalidAgeException : Exception
            //{
            //    public InvalidAgeException(string message) : base(message) { }
            //}

            #endregion


        }
    }
}
