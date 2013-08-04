//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
using System;
class Program
{
    static void Main()
    {
        Console.Write("Type N elements of array = ");
        int n = int.Parse(Console.ReadLine());
        string[] newArray1 = new string[n];
        int start = 0;
        int length = 1;
        int bestStart = 0;
        int bestLength = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array1[{0}] = ", i);
            newArray1[i] = Console.ReadLine();
          
            if (i > 0 && newArray1[i] == newArray1[i - 1])
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
        Console.WriteLine(bestStart + ", "+bestLength);
        for (int k = bestStart; k < bestStart+bestLength; k++)
        {
            Console.Write(newArray1[k]+", ");
        }

    }
}
