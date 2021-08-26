using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciciosCursoCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\File1.txt";
            string targetPath = @"c:\temp\File2.txt";
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}