using System;

namespace Teoria3
{
   class Teoria3
   {
      static void Main(string[] args)
      {
         /*Solução com generics.*/

         Console.Write("How many values? ");
         int n = int.Parse(Console.ReadLine());
         PrintService<int> printService = new PrintService<int>();

         for (int i = 0; i < n; i++)
         {
            printService.AddValue(int.Parse(Console.ReadLine()));
         }

         int a = printService.First();
         a += 2;
         Console.WriteLine(a);

         printService.Print();
         Console.WriteLine("First: " + printService.First());
      }
   }
}
