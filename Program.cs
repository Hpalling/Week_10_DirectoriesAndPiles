using System;
using System.IO;

namespace DirectoriesAndPiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"/Users/heilypalling/Desktop/NÃ¤dal 8 - failid-20220601";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();

            //File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exists");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}

