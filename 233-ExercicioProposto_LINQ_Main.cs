using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using ExerciciosCursoCSharp.Entities;

namespace ExerciciosCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> emp = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    emp.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter Salary: ");
            double mountSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than " + mountSalary.ToString("F2", CultureInfo.InvariantCulture) + ":");
            var emailAVGSalary = emp.Where(p => p.Salary > mountSalary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string email in emailAVGSalary)
            {
                Console.WriteLine(email);
            }

            Console.Write("Sum of salary of people whose name starts with 'M': ");
            var sumMPeoplesSalary = emp.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine(sumMPeoplesSalary);
        }
    }
}
