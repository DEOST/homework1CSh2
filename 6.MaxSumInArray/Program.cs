//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Type N elements of array = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Type K elements of array to find max sum  = ");
        int k = int.Parse(Console.ReadLine());

        int[] newArray1 = new int[n];
        int start = 0;
        int maxSum = 0;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array1[{0}] = ", i);
            newArray1[i] = int.Parse(Console.ReadLine());
            int sum=0;

            if (i < k)
            {
                sum += newArray1[i];
            }
            else
            {
                sum+=newArray1[i]-newArray1[i-k];
            }
            if (sum >= max)
                {
                    max = sum;
                    start = i-k+1;
                }
        }
        if (start<0)
        {
            start = 0;
        }
        for (int j = start; j < start + k; j++)
        {
            Console.Write(newArray1[j]);
            maxSum += newArray1[j];
            if (j < start + k - 1)
            {
                Console.Write(" + ");
            }
            else
            {
                Console.WriteLine(" = {0} ", maxSum);
            }
        }
    }
}
