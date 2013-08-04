//Write a program that allocates array of 20 integers 
//and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
using System;
class Program
{
    static void Main()
    {
        int[] newArray = new int[20];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = i*5;
            Console.Write(newArray[i]+" ");  //Ако печатаме в същия цикъл
        }
        Console.WriteLine();
//      foreach (var item in newArray)  Тук печата е с втори цикъл
//      {
//          Console.Write(item+" ");
//      }
//      Console.WriteLine();
    }
}
