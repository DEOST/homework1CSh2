//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;
    class Program
    {
        static void Main()
        {

            Console.Write("Type N elements of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] newArray1 = new int[n];
            int tempStart = 0;
            int tempLength = 1;
            int start = 0;
            int length = 1;
            for (int i = 0; i < n; i++)
        {
            Console.Write("array1[{0}] = ", i);
            newArray1[i] = int.Parse(Console.ReadLine());

            if (i > 0 && newArray1[i] > newArray1[i - 1])
            {

                tempLength++;
                if (tempLength > length)
                {
                    length = tempLength;
                    start = tempStart;
                }
            }
            else
            {
                tempLength = 1;
                tempStart = i;
            }

        }
            Console.WriteLine(start + ", " + length);
            for (int k = start; k < start + length; k++)
            {
                Console.Write(newArray1[k] + ", ");
            }
        }
    }
