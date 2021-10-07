﻿using System;
using System.Collections.Generic;
using System.Linq;
using ExerciciosCursoCSharp.Entities;

namespace ExerciciosCursoCSharp
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price > 100.0;
        }
    }

}