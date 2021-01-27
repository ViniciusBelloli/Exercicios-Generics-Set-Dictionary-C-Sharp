using System;
using Teoria5.Entities;

namespace Teoria5
{
   class Teoria5
   {
      static void Main(string[] args)
      {
         Client a = new Client("Maria", "maria@gmail.com");
         Client b = new Client("Alex", "alex@gmail.com");

         Console.WriteLine(a.Equals(b));
         Console.WriteLine(a == b);
         Console.WriteLine(a.GetHashCode());
         Console.WriteLine(b.GetHashCode());
      }
   }
}