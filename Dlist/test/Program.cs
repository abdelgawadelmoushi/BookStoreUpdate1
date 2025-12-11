using static System.Net.Mime.MediaTypeNames;

class Program
{
    static List<int> SArr = [ 1, 2, 3, 4, 5 ];

    static (int, int) SwList(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
        return (x, y);


    }

    static void Main(string[] args)
    {
        menu();
    }

    static void menu()
    {
        bool shallExit = false;
        while (!shallExit)
        {
           
            Console.WriteLine("Please enter your choice (sw to swap, q to quit):");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "sw":
                    swap();
                    break;

                case "q":
                    shallExit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }


            static void swap()
        {
            int match = 0;
            int index1 = -1;
            int index2 = -1;
            int f = 0;

            Console.Write("[ ");
            for ( int j = 0;  j < SArr.Count; j++)
            {
                Console.Write($"{SArr[j]} ");
            }
            Console.Write("]");

       
            Console.WriteLine("please enter the first value of swap");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second value of swap");
            int value2 = Convert.ToInt32(Console.ReadLine());

         

            while (true)
            {
                if (SArr[f] == value1)
                {
                    match += 1;
                    index1 = f;
                    
                    
                }
                else if (SArr[f] == value2)
                {
                    match+=1;
                    index2 = f;
                    
                  
                }
                if (match == 2)
                {
                    
                    (SArr[index1], SArr[index2]) = SwList(SArr[index1], SArr[index2]);
                    
                    break;
                }
                if (f == SArr.Count - 1)
                   
                { Console.WriteLine("invalid data");
                    break;
                }
                f++;
             
            }
            Console.Write("[ ");
            for (int j = 0; j < SArr.Count; j++)
            {
                Console.Write($"{SArr[j]} ");
            }
            Console.Write("]");
        }

    }
 

}