//Write a program that finds the sequence of maximal sum in given array. Example:
	//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
class Program
{
    static void Main()
    {
        Console.Write("Type N elements of array = ");
        int n = int.Parse(Console.ReadLine());
        int[] newArray1 = new int[n];
        int start = 0;
        int sum = 0;
        int max = 0;
        int maxStart = 0;
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array1[{0}] = ", i);
            newArray1[i] = int.Parse(Console.ReadLine());
            
            sum += newArray1[i];
           
            if (newArray1[i] >= sum)
            {
                sum = newArray1[i];
                start = i;
            }
            if (sum>max)
            {
                max=sum;
                maxStart = start;
                index = i;
            }
        }
        for (int j = maxStart; j <= index; j++)
        {
            Console.Write(newArray1[j]);
           
            if (j < index)
            {
                Console.Write(newArray1[j]>=0?" + ":" ");
            }
            else
            {
                Console.WriteLine(" = {1} ",newArray1[index], max);
            }
        }
    }
}

