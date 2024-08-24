using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeSniper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> decoded = new List<string>();
            string code = "";

            string outputDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string outputPath = Path.Combine(outputDirectory, "output.txt");

            File.WriteAllText(outputPath, String.Empty);

            Console.Write("Code: ");
            code = Console.ReadLine();

            for(int i = 0; i <= 9; i++)
            {
                string decode = "";
                foreach (char c in code)
                {
                    if (c == '_')
                    {
                        decode += i;
                    }
                    else
                    {
                        decode += c;
                    }
                }
                decoded.Add(decode);
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                string decode = "";
                foreach (char c in code)
                {
                    if (c == '_')
                    {
                        decode += i;
                    }
                    else
                    {
                        decode += c;
                    }
                }
                decoded.Add(decode);
            }

            for (char i = 'A'; i <= 'Z'; i++)
            {
                string decode = "";
                foreach (char c in code)
                {
                    if (c == '_')
                    {
                        decode += i;
                    }
                    else
                    {
                        decode += c;
                    }
                }
                decoded.Add(decode);
            }

            File.AppendAllLines(outputPath, decoded);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done! ^_^");
            Console.ReadKey();
        }
    }
}
