using System;
using System.IO;
namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Text = File.ReadAllLines(@"C:\Users\gaelg\Documents\Periode 4 Eerste jaar\2022P4csharp\FileIOOpdracht\Text.txt");

            foreach (string Line in Text)
                Console.WriteLine(Line);
        }
    }
}
