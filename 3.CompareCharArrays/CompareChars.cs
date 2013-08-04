//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
class Program
{
    static void Main()
    {
        Console.Write("Type N elements of first array = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Type K elements of second array = ");
        int k = int.Parse(Console.ReadLine());
        int length = Math.Min(n,k);
        
        char[] newArray1 = new char[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array1[{0}] = ", i);
            newArray1[i] = Convert.ToChar(Console.ReadLine());
        }
        char[] newArray2 = new char[k];
        for (int i = 0; i < k; i++)
        {
            Console.Write("array2[{0}] = ", i);
            newArray2[i] = Convert.ToChar(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            if (newArray1[i] < newArray2[i])
            {
                Console.WriteLine("first array[{0}]= {1} is lexicographically than second array [{0}]= {2}", i, newArray1[i],newArray2[i]);
            }
            else if (newArray1[i] > newArray2[i])
            {
                Console.WriteLine("second array[{0}]= {2} is lexicographically than second array [{0}]= {1}", i, newArray1[i], newArray2[i]);
            }
            else
            {
                Console.WriteLine("the arrays are equal at index [{0}] ", i);
            }

        }
     }
}
