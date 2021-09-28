using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosCursoCSharp.Entities;

namespace ExerciciosCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Registration> set = new HashSet<Registration>();

            Console.Write("How many students for course A? ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Registration(id));
            }

            Console.Write("How many students for course B? ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Registration(id));
            }

            Console.Write("How many students for course C? ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Registration(id));
            }

            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
