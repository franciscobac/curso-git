using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciciosCursoCSharp
{
    class _187_FIleStream_e_StreamReader
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                throw new IOException(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            Console.WriteLine("---------------------------------------------------------------------");

            //Maneira de trabalhar com o Stream Reader sem a necessidade de instanciar explicitamente o FileStream, com o auxílio da classe File.

            string path2 = @"c:\temp\File2.txt";
            StreamReader sr2 = null;

            try
            {
                sr2 = File.OpenText(path2);

                while (!sr2.EndOfStream)
                {
                    string line2 = sr2.ReadLine();
                    Console.WriteLine(line2);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr2 != null) sr2.Close();
            }
        }
    }
}
