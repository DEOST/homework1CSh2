//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;
class Program
{
    static void Main()
    {
        Console.Write("Type N elements of array = ");
        int n = int.Parse(Console.ReadLine());
        string[] newArray = new string[n];
        int start = 0;
        int length = 1;
        int bestStart = 0;
        int bestLength = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            newArray[i] = Console.ReadLine();
        }
        Array.Sort(newArray);
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && newArray[i] == newArray[i - 1])
            {

                length++;
                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }
            else
            {
                length = 1;
                start = i;
            }

        }
        Console.WriteLine(newArray[bestStart] + " - frequence = " + bestLength);
    }
}
