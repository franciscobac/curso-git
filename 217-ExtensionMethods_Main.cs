using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 10, 01, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine("---------------------------------------------------------");

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
