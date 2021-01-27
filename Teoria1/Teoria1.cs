using System;

namespace Teoria1
{
   class Teoria1
   {
      static void Main(string[] args)
      {
         /*Problema motivador 1 (reuso)
           Se quiser reutilizar com um tipo diferente como o string
           teria que reescrever a função de PrintService
          */

         Console.Write("How many values? ");
         int n = int.Parse(Console.ReadLine());
         PrintService printService = new PrintService();

         for (int i = 0; i < n; i++)
         {
            printService.AddValue(int.Parse(Console.ReadLine()));
         }

         printService.Print();
         Console.WriteLine("First: " + printService.First());
      }
   }
}