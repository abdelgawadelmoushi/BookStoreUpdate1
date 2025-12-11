using System;
using System.Collections.Generic;

internal class NameSpaces
{
    #region whiteSpaces
    // same as before, skipped for clarity
    #endregion

    static (int, int) ArrSwap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        return (x, y);
    }

    static void SwapInList(List<int> list, int index1, int index2)
    {
        int temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }

    static void displaySwapList(List<int> swapList)
    {
        int index1 = -1, index2 = -1, found = 0, i = 0;

        Console.WriteLine("please enter value1:");
        int value1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("please enter value2:");
        int value2 = Convert.ToInt32(Console.ReadLine());

        while (i < swapList.Count)
        {
            if (value1 == swapList[i]) { found++; index1 = i; }
            else if (value2 == swapList[i]) { found++; index2 = i; }

            if (found == 2)
            {
                SwapInList(swapList, index1, index2);  // ✅ works!
                Console.WriteLine("Swapped successfully!");
                break;
            }

            i++;
        }

        if (found != 2)
        {
            Console.WriteLine("Invalid entry");
        }

        Console.Write("[ ");
        foreach (var num in swapList)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine("]");
    }

    static void Main(string[] args)
    {
        int x = 5, y = 16;
        Console.WriteLine($"{x} {y}");
        ArrSwap(ref x, ref y);   // ✅ works with ref
        Console.WriteLine($"{x} {y}");

        List<int> swapList = new List<int> { 1, 2, 3, 4 };
        displaySwapList(swapList);
    }
}
