using System;
using System.Collections.Generic;
using Teoria8.Entities;

namespace Teoria8
{
   class Teoria8
   {
      static void Main(string[] args)
      {
         HashSet<Product> a = new HashSet<Product>();
         a.Add(new Product("TV", 900.0));
         a.Add(new Product("Notebook", 1200.0));

         HashSet<Point> b = new HashSet<Point>();
         b.Add(new Point(3, 4));
         b.Add(new Point(5, 10));

         /*Tipo referência se não estiver implementado o gethashcode
         compara o endereço de memória logo a comparação e falsa
          */
         Product prod = new Product("Notebook", 1200.0);
         Console.WriteLine(a.Contains(prod));

         /*Tipo valor se não estiver implementado o gethashcode
         compara os valores dos atributos logo a comparação da verdadeira
          */
         Point point = new Point(5, 10);
         Console.WriteLine(b.Contains(point));
      }
   }
}