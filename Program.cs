using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
          int [,] myarray = new int [10,10];
          for (int i = 1; i <=10; i++)
           {
             for (int j = 1; j <=10; j++)
             {
               int Result = i * j;
               Console.Write(Result.ToString() +"\t");
                
             } 
             System.Console.WriteLine();
           }
        }
    }
}
