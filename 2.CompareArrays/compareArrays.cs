//Write a program that reads two arrays from the console and compares them element by element.
using System;
    class Program
    {
        static void Main()
        {
            Console.Write("Type N elements of arrays = ");
            int n = int.Parse(Console.ReadLine());

            string[] newArray1 = new string[n];
            string[] newArray2 = new string[n];
            string[] resultArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("array1[{0}] = ", i);
                newArray1[i] = Console.ReadLine();
                Console.Write("array2[{0}] = ", i);
                newArray2[i] = Console.ReadLine();
                resultArray[i] = (newArray1[i] + newArray2[i]);
                 
            }
            int j = 0;
            foreach (var item in resultArray)
            {
                Console.WriteLine("resultArray[{0}] = {1}", j, item);
                j++;
            }
        }
    }

