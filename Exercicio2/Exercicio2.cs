using System;
using System.Collections.Generic;
using Exercicio2.Entities;

namespace Exercicio2
{
   class Exercicio2
   {
      static void Main(string[] args)
      {
         HashSet<Student> students = new HashSet<Student>();

         Console.Write("How many students for course A? ");
         int a = int.Parse(Console.ReadLine());

         for (int i = 0; i < a; i++)
         {
            int idStudent = int.Parse(Console.ReadLine());
            students.Add(new Student(idStudent));
         }

         Console.Write("How many students for course B? ");
         int b = int.Parse(Console.ReadLine());

         for (int i = 0; i < b; i++)
         {
            int idStudent = int.Parse(Console.ReadLine());
            students.Add(new Student(idStudent));
         }

         Console.Write("How many students for course C? ");
         int c = int.Parse(Console.ReadLine());

         for (int i = 0; i < c; i++)
         {
            int idStudent = int.Parse(Console.ReadLine());
            students.Add(new Student(idStudent));
         }

         Console.WriteLine("Total students: " + students.Count);

      }
   }
}