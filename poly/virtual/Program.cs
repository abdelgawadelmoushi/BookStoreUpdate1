

namespace virtual1

{

    public class Helper <T>
    {
       public static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;




        }

    }
internal class Program
{
        
     
    static void Main(string[] args)
    {
            int x = 5;
            int y = 10;

            Console.WriteLine( "before swapping ");
            Console.WriteLine( "int x = " + x);
            Console.WriteLine( "int y = " + y);

            Helper <int> .swap(ref x, ref y);

            Console.WriteLine("after swapping ");
            Console.WriteLine("int x = " + x);
            Console.WriteLine("int y = " + y);


            double d1 = 5.3;
            double d2 = 10.8;

            Console.WriteLine("before swapping ");
            Console.WriteLine("int d1 = " + d1);
            Console.WriteLine("int d2 = " + d2);

            Helper<double>.swap(ref d1, ref d2);

            Console.WriteLine("after swapping ");
            Console.WriteLine("int d1 = " + d1);
            Console.WriteLine("int d2 = " + d2);


            string s1 = "mohamed";
            string s2 = "ahmed";

            Console.WriteLine("before swapping ");
            Console.WriteLine("int s1 = " + s1);
            Console.WriteLine("int s2 = " + s2);

            Helper<string>.swap(ref s1, ref s2);

            Console.WriteLine("after swapping ");
            Console.WriteLine("int s1 = " + s1);
            Console.WriteLine("int s2 = " + s2);


        }
}

}