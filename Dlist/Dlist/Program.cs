using System.Linq;

static void menu()
{

    Console.WriteLine("===================================");

    Console.WriteLine("P - Print numbers \n" +
        "A - Add number \n" +
        "M - Display mean of numbers \n" +
        "S - display the smallest number \n" +
        "L - Display the largest number \n" +
        "F - find a number \n" +
        "C  - clear the whole List \n" +
        "R - Reverse the Numbers \n" +
        "E - Even Of List \n" +
        "T - Total sum of numbers \n" +
        "SW - swap between numbers \n" +
        "CH - Change between number \n" +
        "q - quit");
}

List<int> myArr = new List<int> { 1, 2, 3 };
static void ArrChange(List<int> myArr)
{
    Console.WriteLine("Please enter the old number you need to change:");
    int oldNum = Convert.ToInt32(Console.ReadLine());

    bool found = false; // Flag to track if the number was found

    for (int i = 0; i < myArr.Count; i++)
    {
        if (oldNum == myArr[i])
        {
            Console.WriteLine("The number you entered is found.");
            Console.WriteLine("Please enter the new number you need to add instead:");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            myArr[i] = newNumber;
            Console.WriteLine("The number has been changed.");
            found = true; // Set found flag to true
            break; // Exit loop once the number is swapped
        }
    }

    if (!found)
    {
        Console.WriteLine("The number you have entered is not found.");
    }


    #region another one with while 

    //    Console.WriteLine("Please enter the old number you need to change:");
    //    int oldNum = Convert.ToInt32(Console.ReadLine());

    //    bool found = false; // Flag to track if the number was found
    //    int i = 0; // Start with the first index

    //    while (i < myArr.Count)
    //    {
    //        if (oldNum == myArr[i])
    //        {
    //            Console.WriteLine("The number you entered is found.");
    //            Console.WriteLine("Please enter the new number you need to add instead:");
    //            int newNumber = Convert.ToInt32(Console.ReadLine());
    //            myArr[i] = newNumber;
    //            Console.WriteLine("The number has been changed.");
    //            found = true;
    //            break; // Exit loop once the number is swapped
    //        }
    //        i++; // Move to the next index
    //    }

    //    if (!found)
    //    {
    //        Console.WriteLine("The number you have entered is not found.");
    //    }
    //}
    //}
    #endregion
}

static (int, int) ArrSwap(int x, int y)
{
    int temp = x;
    x = y;
    y = temp;

    return (x, y);
}


void SwapArr()
{
    int index1 = -1;
    int index2 = -1;
    int o = 0;
    Console.WriteLine("please enter value1");
    int value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("please enter value1");
    int value2 = Convert.ToInt32(Console.ReadLine());
    int found = 0;
    while (true)
    {
        if (myArr[o] == value1)
        {
            found += 1;
            index1 = o;
        }
        else if (myArr[o] == value2)
        { found += 1; index2 = o; }
        if (found == 2)
        {
            (myArr[index1], myArr[index2]) = ArrSwap(myArr[index1], myArr[index2]);

            break;
        }
        if (o == myArr.Count - 1)
        {
            Console.WriteLine("invalid data");
            break;
        }
        o++;
    }
    Console.Write("[ ");
    Console.Write($"{myArr[o]}");
    Console.Write(" ]");


}



bool shallExit = false;
while (!shallExit)
{


    Console.WriteLine("please choose from the below");


    menu();

    Console.WriteLine("===================================");

    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "p":
        case "P":
            Console.WriteLine(" ");
            Console.Write("[ ");
            for (int i = 0; i < myArr.Count; i++)
            {
                Console.Write(myArr[i] + " ");

            }
            Console.Write("]");
            Console.WriteLine("");

            break;
            menu();

        case "q":
        case "Q":
            shallExit = true;
            break;
            menu();

        case "ch":
        case "CH":

            ArrChange(myArr);

            break;
            menu();
        case "sw":
        case "SW":
            SwapArr();

            break;
            menu();

        case "e":
        case "E":

            for (int i = 0; i < myArr.Count; i++)
            {
                if (myArr[i] % 2 == 0)
                {
                    {
                        Console.Write($"{myArr[i]} ");
                    }
                }
            }
            Console.WriteLine(" ");
            break;


        case "f":
        case "F":
            Console.WriteLine("please enter the number you want to search");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            int index = myArr.IndexOf(searchNumber);


            if (myArr.Contains(searchNumber))

            {
                Console.WriteLine(value: $"The number you search for {searchNumber} is exist and the index is {index} ");
            }
            else
            {
                Console.WriteLine(value: $"The number you search for {searchNumber} is not exist ");

            }

            break;
            menu();
        case "m":
        case "M":
            int sum = 0;
            for (int i = 0; i < myArr.Count; i++)
            {
                sum += myArr[i];


            }
            Console.WriteLine($"the average is : {sum / myArr.Count} ");


            break;
            menu();


        case "c":
        case "C":
            myArr.Clear();
            Console.WriteLine(" the Array has been clreared susccesfully ");
            break;
            menu();
        case "t":
        case "T":
            int total = 0;
            for (int i = 0; i < myArr.Count; i++)
            {

                total += myArr[i];
            }
            Console.WriteLine($"total sum of numbers is : {total}");
            break;
            menu();

        case "r":
        case "R":
            Console.WriteLine(" ");
            Console.Write("[ ");
            for (int i = myArr.Count - 1; i >= 0; i--)
            {
                {
                    Console.Write(myArr[i] + " ");

                }

            }
            Console.Write("]");
            Console.WriteLine("");
            break;
        case "s":
        case "S":


            int smallest = myArr[0];
            for (int i = 0; i < myArr.Count; i++)

            {
                if (myArr[i] < smallest)
                { smallest = myArr[i]; }


            }
            Console.WriteLine($"smallest number is: {smallest} ");

            break;
            menu();

        case "l":
        case "L":


            int largest = myArr[0];
            for (int i = 0; i < myArr.Count; i++)

            {
                if (myArr[i] > largest)
                { largest = myArr[i]; }

            }
            Console.WriteLine($"largest number is : {largest}");

            break;
            menu();
        case "a":
        case "A":

            Console.Clear();
            bool match = false;

            Console.WriteLine("\nEnter the number:");
            var addedNumber = Convert.ToInt32(Console.ReadLine());
            //فصلت اللوب عن بعضها 

            for (int i = 0; i < myArr.Count; i++)
            {
                if (myArr[i] == addedNumber)
                {
                    match = true;
                    break;
                }
                else
                {
                    match = false;
                }
            }
            while (match)
            {

                Console.WriteLine($"{addedNumber} is already exist , Enter another number");

                addedNumber = Convert.ToInt32(Console.ReadLine());


                // كررت نفس التحقيق الي فوق هنا 

                for (int i = 0; i < myArr.Count; i++)
                {
                    if (myArr[i] == addedNumber)
                    {
                        match = true;
                        break;
                    }
                    else
                    {
                        match = false;
                    }
                }
            }

            //طلعت الشرط ده من اللوب 

            if (!match)

                myArr.Add(addedNumber);

            Console.WriteLine($" number {addedNumber}  has been added ");
            break;

            menu();



            break;

        default:
            Console.WriteLine("Invalid choice");
            break;

    }


}