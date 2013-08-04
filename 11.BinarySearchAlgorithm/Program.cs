using System;

class Program
{
    static void Main()
    {
        Console.Write("Type N elements of array = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Type X for searching  = ");
        int x = int.Parse(Console.ReadLine());

        int[] newArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            newArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(newArray);
        
        for (int l = 0; l <= n-1; )
        {
            int m = l + (n -1 - l) / 2;

            if (newArray[m] < x)
            {
                l = m + 1;
            }
            else if (newArray[m] > x)
            {
                n = m;
            }
            else
            {
                Console.WriteLine(m);
                return;
            }
        }
    }
}