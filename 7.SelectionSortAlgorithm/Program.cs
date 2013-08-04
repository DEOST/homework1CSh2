//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Type N elements of array = ");
        int n = int.Parse(Console.ReadLine());
        int[] newArray = new int[n];
        int minIndex = 0;
        int bufer = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            newArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n-1; i++)
        {
            minIndex = i;
            for (int k = i+1; k < n; k++)
            {
                if (newArray[k]<newArray[minIndex])
                {
                    minIndex = k;
                }
            }
            bufer = newArray[i];
            newArray[i] = newArray[minIndex];
            newArray[minIndex] = bufer;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(newArray[i]);
            if (i < n - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine(" ", newArray[i]);
            }
        }
    }

}

