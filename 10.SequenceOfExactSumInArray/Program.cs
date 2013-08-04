//Write a program that finds in given array of integers
//a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
using System;
class Program
{
    static void Main()
    {
        Console.Write("Type N elements of array = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Type S for sum  = ");
        int k = int.Parse(Console.ReadLine());

        int[] newArray1 = new int[n];
        int start = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("array1[{0}] = ", i);
            newArray1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += newArray1[j];
                if (sum == k)
                {

                    start = i;

                }

            }
        }
            int l = start;
            sum = 0;
            while (sum <= k)
            {
                Console.Write(newArray1[l]);
                sum += newArray1[l];

                if (sum < k)
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.WriteLine(" = {0} ", sum);
                    break;
                }
                l++;
            }
            {

            }
        }
    }


         