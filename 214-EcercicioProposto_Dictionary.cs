using System;
using System.IO;
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

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> result = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (result.ContainsKey(name))
                        {
                            result[name] += votes;
                        }
                        else
                        {
                            result[name] = votes;
                        }
                    }

                    foreach (var x in result)
                    {
                        Console.WriteLine(x.Key + ": " + x.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        }
    }
