using System;
using System.IO;

namespace Pick
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            string wanted = args[1];
            StreamReader reader = File.OpenText(fileName);
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line.IndexOf(wanted) >= 0)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }
            reader.Close();
            //string wait = Console.ReadLine();
        }
    }
}
