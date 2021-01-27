using System;

namespace Teoria2
{
   class Teoria2
   {
      static void Main(string[] args)
      {
         /*Problema motivador 2 (type safety & performance)
            usando o tipo object não se tem segurança 
            de saber o tipo do conteúdo informado,
            problemas de performace podem ocorrer devido ao cast 
            de varíaveis que pode ocorrer.
          */

         Console.Write("How many values? ");
         int n = int.Parse(Console.ReadLine());
         PrintService printService = new PrintService();

         for (int i = 0; i < n; i++)
         {
            printService.AddValue(int.Parse(Console.ReadLine()));
         }

         int a = (int)printService.First();
         a += 2;
         Console.WriteLine(a);

         printService.Print();
         Console.WriteLine("First: " + printService.First());
      }
   }
}